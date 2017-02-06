using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QueryExecutor;
using Modelo;

namespace SQL
{
    public class DBQueriesGeneral
    {
        public static MySQLExecutor executor;

        public static bool LoginUser(string user, string password)
        {
            string query = string.Format("SELECT COUNT(*) FROM usuario WHERE nombreusuario = \"{0}\" AND contrasena = \"{1}\"", user, Utils.Cifrado.MD5(string.Format("ARELIPOS-{0}", password)));
            QueryResult result = executor.ExecuteQuery(query);
            if (result.Status != ExecutorStatus.ERROR_DURING_PROCESS)
            {
                return Convert.ToInt32(result[0][0].Value) > 0;
            }
            else
            {
                throw result.Exception;
            }
        }

        public static List<UnidadProducto> ConsultaUnidadesProducto()
        {
            List<UnidadProducto> unidades = new List<UnidadProducto>();
            QueryResult result = executor.ExecuteQuery("SELECT * FROM unidadproducto ORDER BY nombre");
            if (result.Status != ExecutorStatus.ERROR_DURING_PROCESS)
            {
                for (int r = 0; r < result.RowCount; r++)
                {
                    UnidadProducto unidad = new UnidadProducto();
                    for (int c = 0; c < result.ColumnCount; c++)
                    {
                        unidad.AgregaCampo(result.Columns[c].Name, new QueryResultData(result[r][result.Columns[c].Name].Value, result[r][c].Type));
                    }
                    unidades.Add(unidad);
                }
                return unidades;
            }
            throw result.Exception;
        }

        public static List<Departamento> ConsultaDepartamentosProductos()
        {
            List<Departamento> departamentos = new List<Departamento>();
            QueryResult result = executor.ExecuteQuery("SELECT * FROM departamento");
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                for (int r = 0; r < result.RowCount; r++)
                {
                    Departamento depa = new Departamento();
                    for (int c = 0; c < result.ColumnCount; c++)
                    {
                        depa.AgregaCampo(result.Columns[c].Name, new QueryResultData(result[r][result.Columns[c].Name].Value, result[r][c].Type));
                    }
                    departamentos.Add(depa);
                }
                return departamentos;
            }
            throw result.Exception;
        }

        public static List<Proveedor> ConsultaProveedoresProductos()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            QueryResult result = executor.ExecuteQuery("SELECT * FROM proveedor");
            if (result.Status != ExecutorStatus.ERROR_DURING_PROCESS)
            {
                for (int r = 0; r < result.RowCount; r++)
                {
                    Proveedor prov = new Proveedor();
                    for (int c = 0; c < result.ColumnCount; c++)
                    {
                        prov.AgregaCampo(result.Columns[c].Name, new QueryResultData(result[r][result.Columns[c].Name].Value));
                    }
                    proveedores.Add(prov);
                }
                return proveedores;
            }
            throw result.Exception;
        }

        public static List<Cliente> ConsultaClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            QueryResult result = executor.ExecuteQuery("SELECT * FROM cliente");
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                for (int i = 0; i < result.RowCount; i++)
                {
                    Cliente cliente = new Cliente();
                    foreach (QueryResultColumn col in result.Columns)
                    {
                        cliente.AgregaCampo(col.Name, result[i][col.Name]);
                    }
                    clientes.Add(cliente);
                }
                return clientes;
            }
            else
            {
                throw new Exception("Error al consultar lista de clientes.");
            }
        }

        public static List<Producto> ConsultaProductos()
        {
            List<Producto> productos = new List<Producto>();
            QueryResult result = executor.ExecuteQuery("SELECT idproducto, codigo, descripcion, preciocosto, precioventa, existencia, minimo, iddepartamento as departamento, departamento.nombre AS nombredepartamento, idproveedor as proveedor, proveedor.nombre AS nombreproveedor, idunidadproducto as unidadproducto, unidadproducto.nombre AS nombreunidadproducto, producto.inventario AS inventario, producto.agranel AS agranel, producto.activo AS activo FROM producto JOIN departamento ON producto.departamento = iddepartamento JOIN proveedor ON producto.proveedor = idproveedor JOIN unidadproducto ON producto.unidadproducto = idunidadproducto;");
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                for (int i = 0; i < result.RowCount; i++)
                {
                    Producto producto = new Producto();
                    foreach (QueryResultColumn col in result.Columns)
                    {
                        producto.AgregaCampo(col.Name, result[i][col.Name]);
                    }
                    productos.Add(producto);
                }
                return productos;
            }
            else
            {
                throw new Exception("Error al consultar lista de productos.");
            }
        }

        public static void InsertaCliente(Cliente cliente)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("INSERT INTO {0}({1}) VALUES({2})", cliente.Tabla, cliente.ListaCampos(), cliente.ListaValores()));
        }

        public static bool EliminaCliente(Cliente cliente)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT COUNT(*) FROM venta WHERE venta.cliente = {0}", cliente["idcliente"].Value));
            if (result.Status != ExecutorStatus.CLOSED_CONNECTION)
            {
                throw new Exception("Error al buscar ventas relacionadas con el cliente especificado");
            }
            else
            {
                int ventas = result[0][0].ToIn32();
                if (ventas == 0)
                {
                    result = executor.ExecuteQuery(string.Format("DELETE FROM {0} WHERE idcliente = {1};", cliente.Tabla, cliente["idcliente"].Value.ToString()));
                    return result.Status == ExecutorStatus.CLOSED_CONNECTION;
                }
                else
                {
                    throw new Exception("No se puede eliminar un cliente que tenga ventas registradas.");
                }
            }
        }

        public static void InsertaProveedor(Proveedor proveedor)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("INSERT INTO {0}({1}) VALUES({2})", proveedor.Tabla, proveedor.ListaCampos(), proveedor.ListaValores()));
        }

        public static bool EliminaProveedor(Proveedor proveedor)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT COUNT(*) FROM producto WHERE producto.proveedor = {0}", proveedor["idproveedor"].Value));
            if (result.Status != ExecutorStatus.CLOSED_CONNECTION)
            {
                throw new Exception("Error al buscar productos relacionadas con el proveedor especificado.");
            }
            else
            {
                int productos = result[0][0].ToIn32();
                if (productos == 0)
                {
                    result = executor.ExecuteQuery(string.Format("DELETE FROM {0} WHERE idproveedor = {1}", proveedor.Tabla, proveedor["idproveedor"].Value.ToString()));
                    return result.Status == ExecutorStatus.CLOSED_CONNECTION;
                }
                else
                {
                    throw new Exception("No se puede eliminar un proveedor que tiene productos registrados.");
                }
            }
        }

        public static void InsertaDepartamento(Departamento departamento)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("INSERT INTO {0}({1}) VALUES({2})", departamento.Tabla, departamento.ListaCampos(), departamento.ListaValores()));
        }

        public static bool EliminaDepartamento(Departamento departamento)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT COUNT(*) FROM producto WHERE producto.departamento = {0}", departamento["iddepartamento"].Value));
            if (result.Status != ExecutorStatus.CLOSED_CONNECTION)
            {
                throw new Exception("Error al buscar productos con el departamento especificado.");
            }
            else
            {
                int productos = result[0][0].ToIn32();
                if (productos == 0)
                {
                    result = executor.ExecuteQuery(string.Format("DELETE FROM {0} WHERE iddepartamento = {1}", departamento.Tabla, departamento["iddepartamento"].Value.ToString()));
                    return result.Status == ExecutorStatus.CLOSED_CONNECTION;
                }
                else
                {
                    throw new Exception("No se puede eliminar un departamento que tiene productos registrados.");
                }
            }
        }

        public static void InsertaProducto(Producto producto)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("INSERT INTO {0}({1}) VALUES({2})", producto.Tabla, producto.ListaCampos(), producto.ListaValores()));
        }

        public static bool EliminaProducto(Producto producto)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT COUNT(*) FROM detalleventa WHERE detalleventa.producto = {0}", producto["idproducto"].Value));
            if (result.Status != ExecutorStatus.CLOSED_CONNECTION)
            {
                throw new Exception("Error al buscar ventas con el producto especificado.");
            }
            else
            {
                int ventas = result[0][0].ToIn32();
                if (ventas == 0)
                {
                    result = executor.ExecuteQuery(string.Format("DELETE FROM {0} WHERE idproducto = {1}", producto.Tabla, producto["idproducto"].Value.ToString()));
                    return result.Status == ExecutorStatus.CLOSED_CONNECTION;
                }
                else
                {
                    throw new Exception("No se puede eliminar un producto que tiene ventas registrados.");
                }
            }
        }

        public static Producto ConsultaProductoPorCodigo(string codigo)
        {
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT idproducto, codigo, descripcion, preciocosto, precioventa, existencia, minimo, iddepartamento as departamento, departamento.nombre AS nombredepartamento, idproveedor as proveedor, proveedor.nombre AS nombreproveedor, idunidadproducto as unidadproducto, unidadproducto.nombre AS nombreunidadproducto, producto.inventario AS inventario, producto.agranel AS agranel, producto.activo AS activo FROM producto JOIN departamento ON producto.departamento = iddepartamento JOIN proveedor ON producto.proveedor = idproveedor JOIN unidadproducto ON producto.unidadproducto = idunidadproducto AND producto.codigo = '{0}'", codigo));
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                if (result.RowCount > 0)
                {
                    Producto producto = new Producto();
                    foreach (QueryResultColumn col in result.Columns)
                    {
                        producto.AgregaCampo(col.Name, result[0][col.Name]);
                    }
                    return producto;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public static List<Producto> BuscaProductos(string texto)
        {
            List<Producto> productos = new List<Producto>();
            QueryResult result = executor.ExecuteQuery(string.Format("SELECT idproducto, codigo, descripcion, preciocosto, precioventa, existencia, minimo, iddepartamento as departamento, departamento.nombre AS nombredepartamento, idproveedor as proveedor, proveedor.nombre AS nombreproveedor, idunidadproducto as unidadproducto, unidadproducto.nombre AS nombreunidadproducto, producto.inventario AS inventario, producto.agranel AS agranel, producto.activo AS activo FROM producto JOIN departamento ON producto.departamento = iddepartamento JOIN proveedor ON producto.proveedor = idproveedor JOIN unidadproducto ON producto.unidadproducto = idunidadproducto WHERE CONCAT(codigo, ' ', descripcion) LIKE '%{0}' OR CONCAT(codigo, ' ', descripcion) LIKE '%{0}%' OR CONCAT(codigo, ' ', descripcion) LIKE '{0}%' AND producto.activo = 1;", texto));
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                for (int i = 0; i < result.RowCount; i++)
                {
                    Producto producto = new Producto();
                    foreach (QueryResultColumn col in result.Columns)
                    {
                        producto.AgregaCampo(col.Name, result[i][col.Name]);
                    }
                    productos.Add(producto);
                }
                return productos;
            }
            else
            {
                if (result.Exception != null)
                {
                    throw result.Exception;
                }
                else
                {
                    throw new Exception("Error al consultar productos");
                }
            }
        }

        public static List<Producto> ConsultaProductosFiltros(string descripcion, Departamento depa, Proveedor prov)
        {
            descripcion = (descripcion.Trim() == string.Empty) ? string.Empty : string.Format(" AND (producto.descripcion LIKE \"%{0}\" OR producto.descripcion LIKE \"%{0}%\" OR producto.descripcion = \"{0}%\")", descripcion);
            string departamento = (depa != null) ? (depa["nombre"].ToString() == "TODOS") ? string.Empty : string.Format(" AND producto.departamento = {0}", depa["iddepartamento"].ToIn32()) : string.Empty;
            string proveedor = (prov != null) ? (prov["nombre"].ToString() == "TODOS") ? string.Empty : string.Format(" AND producto.proveedor = {0}", prov["idproveedor"].ToIn32()) : string.Empty;

            string query = string.Format("SELECT idproducto, codigo, descripcion, preciocosto, precioventa, existencia, minimo, iddepartamento as departamento, departamento.nombre AS nombredepartamento, idproveedor as proveedor, proveedor.nombre AS nombreproveedor, idunidadproducto as unidadproducto, unidadproducto.nombre AS nombreunidadproducto, producto.inventario AS inventario, producto.agranel AS agranel, producto.activo AS activo FROM producto JOIN departamento ON producto.departamento = iddepartamento JOIN proveedor ON producto.proveedor = idproveedor JOIN unidadproducto ON producto.unidadproducto = idunidadproducto {0} {1} {2};", descripcion, departamento, proveedor);

            List<Producto> productos = new List<Producto>();
            QueryResult result = executor.ExecuteQuery(query);
            if (result.Status == ExecutorStatus.CLOSED_CONNECTION)
            {
                for (int i = 0; i < result.RowCount; i++)
                {
                    Producto producto = new Producto();
                    foreach (QueryResultColumn col in result.Columns)
                    {
                        producto.AgregaCampo(col.Name, result[i][col.Name]);
                    }
                    productos.Add(producto);
                }
                return productos;
            }
            else
            {
                throw new Exception("Error al consultar lista de productos.");
            }
        }
    }
}

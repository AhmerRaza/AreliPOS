using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo;
using QueryExecutor;

namespace Modelo
{
    public class Producto : AbstractModelo
    {
        string[] campos = new string[] { "idproducto", "codigo", "descripcion", "preciocosto", "precioventa", "inventario", "existencia", "minimo", "departamento", "proveedor", "unidadproducto", "activo", "agranel" };

        public Producto()
            : base() { }

        public override string ListaCampos()
        {
            string parametros = string.Empty;
            foreach (KeyValuePair<string, QueryResultData> campo in _datos)
            {
                if(campos.Contains(campo.Key))
                {
                    parametros += "`" + campo.Key + "`, ";
                }
            }
            return parametros.Substring(0, parametros.Length - 2);
        }

        public override string ListaValores()
        {
            string valores = string.Empty;
            foreach (KeyValuePair<string, QueryResultData> campo in _datos)
            {
                if (campos.Contains(campo.Key))
                {
                    switch (campo.Value.Type)
                    {
                        case DataType.INTEGER:
                        case DataType.DOUBLE:
                        case DataType.DECIMAL:
                            valores += campo.Value.Value.ToString() + ", ";
                            break;
                        case DataType.STRING:
                            valores += "\"" + campo.Value.Value.ToString() + "\", ";
                            break;
                        case DataType.DATETIME:
                            valores += "\"" + ((DateTime)campo.Value.Value).ToString() + "\", ";
                            break;
                        case DataType.TIME:
                            valores += "\"" + ((TimeSpan)campo.Value.Value).ToString() + "\", ";
                            break;
                        case DataType.BOOL:
                            valores += ((campo.Value.Value.ToString() == "True") ? "1" : "0") + ", ";
                            break;
                    }
                }
            }
            return valores.Substring(0, valores.Length - 2);
        }

        public override void Update(MySQLExecutor executor)
        {
            string valorId = string.Empty;
            string parametros = string.Empty;
            foreach (KeyValuePair<string, QueryResultData> campo in _datos)
            {
                if (campos.Contains(campo.Key))
                {
                    if (_id != campo.Key)
                    {
                        parametros += campo.Key + " = ";

                        switch (campo.Value.Type)
                        {
                            case DataType.INTEGER:
                            case DataType.DOUBLE:
                            case DataType.DECIMAL:
                                parametros += campo.Value.Value.ToString() + ", ";
                                break;
                            case DataType.BOOL:
                                parametros += ((campo.Value.Value.ToString() == "True") ? "1" : "0") + ", ";
                                break;
                            case DataType.STRING:
                                parametros += "\"" + campo.Value.Value.ToString() + "\", ";
                                break;
                            case DataType.DATETIME:
                                parametros += "\"" + ((DateTime)campo.Value.Value).ToString() + "\", ";
                                break;
                            case DataType.TIME:
                                parametros += "\"" + ((TimeSpan)campo.Value.Value).ToString() + "\", ";
                                break;
                        }
                    }
                    else
                    {
                        valorId = campo.Value.Value.ToString();
                    }
                }
            }
            string query = string.Format("UPDATE {0} SET {1} WHERE {2} = {3};", _table, parametros.Substring(0, parametros.Length - 2), _id, valorId);
            QueryResult result = executor.ExecuteQuery(query);
        }
    }
}

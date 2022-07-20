using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wcontrato.Model
{
    class BD
    {

        public static string _conectionString;
        public BD()
        {
            _conectionString =
                    "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + Globals.dbPath + ";" +
                    "ConnectionTimeout=0;" +
                    "DataSource=localhost;" +
                    "Port=3050;" +
                    "Dialect=3;" +
                    "Charset=ISO8859_1;" +
                    "Role=;" +
                    "Connection lifetime=15;" +
                    "Pooling=true;" +
                    "MinPoolSize=0;" +
                    "MaxPoolSize=50;" +
                    "Packet Size=8192;" +
                    "ServerType=0";
        }
        public static FbConnection conectaBd()
        {
            BD bD = new BD();
            return new FbConnection(bD.retornaConnectionString());
        }

        public string retornaConnectionString()
        {
            return _conectionString;
        }


        public static Cliente ObtemDadosCliente(int idCliente)
        {

            Cliente cliente = null;

            using (FbConnection conexaoFireBird = BD.conectaBd())
            {
                try
                {


                    conexaoFireBird.Open();
                    string mSQL = @"select wc.id_cliente, wc.cnpj_cpf, wc.nome_razao, wc.endereco, coalesce(wc.ender_num,0) as ender_num,
                    wc.bairro, wc.cidade, wc.uf, coalesce(wc.contrato_dia_vcto,0) as contrato_dia_vcto, wc.socio_nome1, wc.socio_cpf1, wc.socio_rg1, wc.socio_adm1,
                    wc.socio_nome2, wc.socio_cpf2, wc.socio_rg2, wc.socio_adm2, wc.socio_nome3, wc.socio_cpf3, wc.socio_rg3, wc.socio_adm3
                    from web_clie wc where wc.id_cliente = " + idCliente;

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cliente =
                            new Cliente() {
                                idCliente = int.Parse(dr["ID_CLIENTE"].ToString()),
                                cnpjCpf = dr["CNPJ_CPF"].ToString(),
                                nomeRazao = dr["NOME_RAZAO"].ToString(),
                                enderRua = dr["ENDERECO"].ToString(),
                                enderCidade = dr["CIDADE"].ToString(),
                                enderUF = dr["UF"].ToString(),
                                enderBairro = dr["BAIRRO"].ToString(),
                                enderNum = int.Parse(dr["ENDER_NUM"].ToString()),
                                dataVctoFatura = int.Parse(dr["CONTRATO_DIA_VCTO"].ToString()),
                                socioAdm1 = dr["SOCIO_ADM1"].ToString(),
                                socioCpf1 = dr["SOCIO_CPF1"].ToString(),
                                socioRg1 = dr["SOCIO_RG1"].ToString(),
                                socioNome1 = dr["SOCIO_NOME1"].ToString(),
                                socioAdm2 = dr["SOCIO_ADM2"].ToString(),
                                socioCpf2 = dr["SOCIO_CPF2"].ToString(),
                                socioRg2 = dr["SOCIO_RG2"].ToString(),
                                socioNome2 = dr["SOCIO_NOME2"].ToString(),
                                socioAdm3 = dr["SOCIO_ADM3"].ToString(),
                                socioCpf3 = dr["SOCIO_CPF3"].ToString(),
                                socioRg3 = dr["SOCIO_RG3"].ToString(),
                                socioNome3 = dr["SOCIO_NOME3"].ToString(),
                            };

                    }

                    return cliente;
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("ERRO L96XAX6Q61: " + fbex.Message);
                    return null;
                }
                finally
                {
                    conexaoFireBird.Close();
                }

            }

        }
    }

}

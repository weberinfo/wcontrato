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


            _conectionString = "User=SYSDBA;Password=masterkey;Database=" + Globals.dbPath + ";DataSource=localhost;Port=3050;Dialect=3;Charset=NONE;Role=;Connection lifetime=1;Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0;AuthPlugins=Legacy_Auth;";

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
                    wc.socio_nome2, wc.socio_cpf2, wc.socio_rg2, wc.socio_adm2, wc.socio_nome3, wc.socio_cpf3, wc.socio_rg3, wc.socio_adm3,
                    coalesce(wc.contrato_qtd_tef,0) as contrato_qtd_tef,  coalesce(wc.contrato_qtd_pdv,0) as contrato_qtd_pdv, coalesce(wc.contrato_qtd_term,0) as contrato_qtd_term
                    from web_clie wc where wc.id_cliente = " + idCliente;

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        cliente =
                            new Cliente()
                            {
                                ID_CLIENTE = int.Parse(dr["ID_CLIENTE"].ToString()),
                                CNPJ_CPF = dr["CNPJ_CPF"].ToString(),
                                NOME_RAZAO = dr["NOME_RAZAO"].ToString(),
                                ENDERECO = dr["ENDERECO"].ToString(),
                                CIDADE = dr["CIDADE"].ToString(),
                                UF = dr["UF"].ToString(),
                                BAIRRO = dr["BAIRRO"].ToString(),
                                ENDER_NUM = dr["ENDER_NUM"].ToString(),
                                CONTRATO_DIA_VCTO = dr["CONTRATO_DIA_VCTO"].ToString(),
                                SOCIO_ADM1 = dr["SOCIO_ADM1"].ToString(),
                                SOCIO_CPF1 = dr["SOCIO_CPF1"].ToString(),
                                SOCIO_RG1 = dr["SOCIO_RG1"].ToString(),
                                SOCIO_NOME1 = dr["SOCIO_NOME1"].ToString(),
                                SOCIO_ADM2 = dr["SOCIO_ADM2"].ToString(),
                                SOCIO_CPF2 = dr["SOCIO_CPF2"].ToString(),
                                SOCIO_RG2 = dr["SOCIO_RG2"].ToString(),
                                SOCIO_NOME2 = dr["SOCIO_NOME2"].ToString(),
                                SOCIO_ADM3 = dr["SOCIO_ADM3"].ToString(),
                                SOCIO_CPF3 = dr["SOCIO_CPF3"].ToString(),
                                SOCIO_RG3 = dr["SOCIO_RG3"].ToString(),
                                SOCIO_NOME3 = dr["SOCIO_NOME3"].ToString(),
                                CONTRATO_QTD_TEF = int.Parse(dr["CONTRATO_QTD_TEF"].ToString()),
                                CONTRATO_QTD_PDV = int.Parse(dr["CONTRATO_QTD_PDV"].ToString()),
                                CONTRATO_QTD_TERM = int.Parse(dr["CONTRATO_QTD_TERM"].ToString()),
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

using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NFeMix.Entidades.NFSe;

namespace NFeMix.Mapeamento.NFSe
{
    public class GRS_NFSeMap : ClassMap<GRS_NFSe>
    {
        public GRS_NFSeMap()
        {
            Table("GRS_NFSe");
            Id(x => x.Id_Grs_Nfse, "id_grs_nfse").GeneratedBy.Native();

            Map(x => x.Versao_Layout, "versao_layout").Length(5);
            Map(x => x.Id_Modelo_Documento_Fiscal, "id_modelo_documento_fiscal");
            Map(x => x.Id_Serie_Documento_Fiscal, "id_serie_documento_fiscal");
            Map(x => x.Numero_Protocolo, "numero_protocolo").Length(50);
            Map(x => x.Data_Hora_Emissao, "data_hora_emissao");
            Map(x => x.Operacao, "operacao");
            Map(x => x.Chave_Documento_Fiscal, "chave_documento_fiscal").Length(47);
            Map(x => x.Id_Situacao_Documento_Fiscal, "id_situacao_documento_fiscal");
            Map(x => x.Data_Hora_Cancelamento, "data_hora_cancelamento");
            Map(x => x.Motivo_Cancelamento, "motivo_cancelamento").Length(40);
            Map(x => x.Numero_Protocolo_Cancelamento, "numero_protocolo_cancelamento").Length(50);
            Map(x => x.Numero_Rps, "numero_rps");
            Map(x => x.Serie_Rps, "serie_rps").Length(50);
            Map(x => x.Data_Hora_Emissa_Rps, "data_hora_emissa_rps");
            Map(x => x.Ambiente, "ambiente");
            Map(x => x.Id_Filial, "id_filial");
            Map(x => x.Prest_Nome, "prest_nome").Length(150);
            Map(x => x.Prest_Nome_Fantasia, "prest_nome_fantasia").Length(60);
            Map(x => x.Prest_Cnpj, "prest_cnpj").Length(14);
            Map(x => x.Prest_Im, "prest_im").Length(15);
            Map(x => x.Prest_Email, "prest_email").Length(50);
            Map(x => x.Prest_Site, "prest_site").Length(50);
            Map(x => x.Prest_Logradouro, "prest_logradouro").Length(100);
            Map(x => x.Prest_Numero, "prest_numero").Length(6);
            Map(x => x.Prest_Complemento, "prest_complemento").Length(100);
            Map(x => x.Prest_Bairro, "prest_bairro").Length(100);
            Map(x => x.Prest_Id_Cidade, "prest_id_cidade");
            Map(x => x.Prest_Cod_Ibge_Cidade, "prest_cod_ibge_cidade");
            Map(x => x.Prest_Desc_Cidade, "prest_desc_cidade").Length(100);
            Map(x => x.Prest_Sigla_Uf, "prest_sigla_uf").Length(10);
            Map(x => x.Prest_Cod_Ibge_Uf, "prest_cod_ibge_uf").Length(10);
            Map(x => x.Prest_Cod_Ibge_Pais, "prest_cod_ibge_pais").Length(10);
            Map(x => x.Prest_Desc_Pais, "prest_desc_pais").Length(10);
            Map(x => x.Prest_Cep, "prest_cep").Length(8);
            Map(x => x.Prest_Fone_Ddd, "prest_fone_ddd").Length(3);
            Map(x => x.Prest_Fone_Numero, "prest_fone_numero").Length(18);
            Map(x => x.Prest_Ie, "prest_ie").Length(15);
            Map(x => x.Id_Entidade, "id_entidade");
            Map(x => x.Tom_Nome, "tom_nome").Length(100);
            Map(x => x.Tom_Cpf, "tom_cpf").Length(11);
            Map(x => x.Tom_Cnpj, "tom_cnpj").Length(14);
            Map(x => x.Tom_Email, "tom_email").Length(120);
            Map(x => x.Tom_Ie, "tom_ie").Length(15);
            Map(x => x.Tom_Im, "tom_im").Length(15);
            Map(x => x.Tom_Fone_Ddd, "tom_fone_ddd").Length(3);
            Map(x => x.Tom_Fone_Numero, "tom_fone_numero").Length(18);
            Map(x => x.Tom_Logradouro, "tom_logradouro").Length(100);
            Map(x => x.Tom_Numero, "tom_numero").Length(6);
            Map(x => x.Tom_Complemento, "tom_complemento").Length(100);
            Map(x => x.Tom_Bairro, "tom_bairro").Length(100);
            Map(x => x.Tom_Id_Cidade, "tom_id_cidade");
            Map(x => x.Tom_Cod_Ibge_Cidade, "tom_cod_ibge_cidade");
            Map(x => x.Tom_Desc_Cidade, "tom_desc_cidade").Length(100);
            Map(x => x.Tom_Cep, "tom_cep").Length(8);
            Map(x => x.Tom_Cod_Ibge_Uf, "tom_cod_ibge_uf");
            Map(x => x.Tom_Sigla_Uf, "tom_sigla_uf").Length(10);
            Map(x => x.Tom_Cod_Ibge_Pais, "tom_cod_ibge_pais").Length(10);
            Map(x => x.Tom_Desc_Pais, "tom_desc_pais").Length(100);
            Map(x => x.Id_Entidade_Transportadora, "id_entidade_transportadora");
            Map(x => x.Trans_Nome, "trans_nome").Length(100);
            Map(x => x.Trans_Cpf_Cnpj, "trans_cpf_cnpj").Length(14);
            Map(x => x.Trans_Ie, "trans_ie").Length(15);
            Map(x => x.Trans_Placa, "trans_placa").Length(10);
            Map(x => x.Trans_Endereco, "trans_endereco").Length(100);
            Map(x => x.Trans_Id_Cidade, "trans_id_cidade");
            Map(x => x.Trans_Cod_Ibge_Cidade, "trans_cod_ibge_cidade");
            Map(x => x.Trans_Desc_Cidade, "trans_desc_cidade").Length(100);
            Map(x => x.Trans_Tipo_Frete, "trans_tipo_frete");
            Map(x => x.Trans_Cod_Ibge_Uf, "trans_cod_ibge_uf");
            Map(x => x.Trans_Sigla_Uf, "trans_sigla_uf").Length(10);
            Map(x => x.Trans_Cod_Ibge_Pais, "trans_cod_ibge_pais").Length(10);
            Map(x => x.Trans_Desc_Pais, "trans_desc_pais").Length(100);
            Map(x => x.Tot_Valor_Servico, "tot_valor_servico").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Reducao_Bc_Contrucao_Civil, "tot_valor_reducao_bc_contrucao_civil").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Desconto, "tot_valor_desconto").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Total_Nota, "tot_valor_total_nota").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Total_Liquido, "tot_valor_total_liquido").Precision(13).Scale(2);
            Map(x => x.Tot_Total_Aprox_Tributos, "tot_total_aprox_tributos").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Liq_Faturas, "tot_valor_liq_faturas").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Bc_Iss, "tot_valor_bc_iss").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Iss, "tot_valor_iss").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_Bc_St_Iss, "tot_valor_bc_st_iss").Precision(13).Scale(2);
            Map(x => x.Tot_Valor_St_Iss, "tot_valor_st_iss").Precision(13).Scale(2);
            Map(x => x.Ret_Ir, "ret_ir").Precision(13).Scale(2);
            Map(x => x.Ret_Pispasep, "ret_pispasep").Precision(13).Scale(2);
            Map(x => x.Ret_Cofins, "ret_cofins").Precision(13).Scale(2);
            Map(x => x.Ret_Csll, "ret_csll").Precision(13).Scale(2);
            Map(x => x.Ret_Inss, "ret_inss").Precision(13).Scale(2);
        }
    }
}

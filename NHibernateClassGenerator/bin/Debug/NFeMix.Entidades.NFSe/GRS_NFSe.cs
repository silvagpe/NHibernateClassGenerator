using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NFeMix.Entidades.NFSe
{
    public class GRS_NFSe : IEntidade
    {
        public virtual int Id_Grs_Nfse { get; set; }

        public virtual string Versao_Layout { get; set; }

        public virtual short? Id_Modelo_Documento_Fiscal { get; set; }

        public virtual short? Id_Serie_Documento_Fiscal { get; set; }

        public virtual string Numero_Protocolo { get; set; }

        public virtual DateTime? Data_Hora_Emissao { get; set; }

        public virtual short? Operacao { get; set; }

        public virtual string Chave_Documento_Fiscal { get; set; }

        public virtual short? Id_Situacao_Documento_Fiscal { get; set; }

        public virtual DateTime? Data_Hora_Cancelamento { get; set; }

        public virtual string Motivo_Cancelamento { get; set; }

        public virtual string Numero_Protocolo_Cancelamento { get; set; }

        public virtual int? Numero_Rps { get; set; }

        public virtual string Serie_Rps { get; set; }

        public virtual DateTime? Data_Hora_Emissa_Rps { get; set; }

        public virtual int? Ambiente { get; set; }

        public virtual short? Id_Filial { get; set; }

        public virtual string Prest_Nome { get; set; }

        public virtual string Prest_Nome_Fantasia { get; set; }

        public virtual string Prest_Cnpj { get; set; }

        public virtual string Prest_Im { get; set; }

        public virtual string Prest_Email { get; set; }

        public virtual string Prest_Site { get; set; }

        public virtual string Prest_Logradouro { get; set; }

        public virtual string Prest_Numero { get; set; }

        public virtual string Prest_Complemento { get; set; }

        public virtual string Prest_Bairro { get; set; }

        public virtual int? Prest_Id_Cidade { get; set; }

        public virtual int? Prest_Cod_Ibge_Cidade { get; set; }

        public virtual string Prest_Desc_Cidade { get; set; }

        public virtual string Prest_Sigla_Uf { get; set; }

        public virtual string Prest_Cod_Ibge_Uf { get; set; }

        public virtual string Prest_Cod_Ibge_Pais { get; set; }

        public virtual string Prest_Desc_Pais { get; set; }

        public virtual string Prest_Cep { get; set; }

        public virtual string Prest_Fone_Ddd { get; set; }

        public virtual string Prest_Fone_Numero { get; set; }

        public virtual string Prest_Ie { get; set; }

        public virtual int? Id_Entidade { get; set; }

        public virtual string Tom_Nome { get; set; }

        public virtual string Tom_Cpf { get; set; }

        public virtual string Tom_Cnpj { get; set; }

        public virtual string Tom_Email { get; set; }

        public virtual string Tom_Ie { get; set; }

        public virtual string Tom_Im { get; set; }

        public virtual string Tom_Fone_Ddd { get; set; }

        public virtual string Tom_Fone_Numero { get; set; }

        public virtual string Tom_Logradouro { get; set; }

        public virtual string Tom_Numero { get; set; }

        public virtual string Tom_Complemento { get; set; }

        public virtual string Tom_Bairro { get; set; }

        public virtual int? Tom_Id_Cidade { get; set; }

        public virtual int? Tom_Cod_Ibge_Cidade { get; set; }

        public virtual string Tom_Desc_Cidade { get; set; }

        public virtual string Tom_Cep { get; set; }

        public virtual int? Tom_Cod_Ibge_Uf { get; set; }

        public virtual string Tom_Sigla_Uf { get; set; }

        public virtual string Tom_Cod_Ibge_Pais { get; set; }

        public virtual string Tom_Desc_Pais { get; set; }

        public virtual int? Id_Entidade_Transportadora { get; set; }

        public virtual string Trans_Nome { get; set; }

        public virtual string Trans_Cpf_Cnpj { get; set; }

        public virtual string Trans_Ie { get; set; }

        public virtual string Trans_Placa { get; set; }

        public virtual string Trans_Endereco { get; set; }

        public virtual int? Trans_Id_Cidade { get; set; }

        public virtual int? Trans_Cod_Ibge_Cidade { get; set; }

        public virtual string Trans_Desc_Cidade { get; set; }

        public virtual int? Trans_Tipo_Frete { get; set; }

        public virtual int? Trans_Cod_Ibge_Uf { get; set; }

        public virtual string Trans_Sigla_Uf { get; set; }

        public virtual string Trans_Cod_Ibge_Pais { get; set; }

        public virtual string Trans_Desc_Pais { get; set; }

        public virtual decimal? Tot_Valor_Servico { get; set; }

        public virtual decimal? Tot_Valor_Reducao_Bc_Contrucao_Civil { get; set; }

        public virtual decimal? Tot_Valor_Desconto { get; set; }

        public virtual decimal? Tot_Valor_Total_Nota { get; set; }

        public virtual decimal? Tot_Valor_Total_Liquido { get; set; }

        public virtual decimal? Tot_Total_Aprox_Tributos { get; set; }

        public virtual decimal? Tot_Valor_Liq_Faturas { get; set; }

        public virtual decimal? Tot_Valor_Bc_Iss { get; set; }

        public virtual decimal? Tot_Valor_Iss { get; set; }

        public virtual decimal? Tot_Valor_Bc_St_Iss { get; set; }

        public virtual decimal? Tot_Valor_St_Iss { get; set; }

        public virtual decimal? Ret_Ir { get; set; }

        public virtual decimal? Ret_Pispasep { get; set; }

        public virtual decimal? Ret_Cofins { get; set; }

        public virtual decimal? Ret_Csll { get; set; }

        public virtual decimal? Ret_Inss { get; set; }

    }
}

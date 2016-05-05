using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NHibernateClassGenerator.Helpers
{
    public class CriptografiaHelper
    {
        private string cryptoKey = string.Empty;

        private string _chave = string.Empty;

        public CriptografiaHelper()
        {
            _chave = "ABCDEFGHIJL";
            cryptoKey = _chave.PadRight(32, '0');
        }

        #region Métodos de Criptografia e Descriptografia

        /// <summary>    
        /// Vetor de bytes utilizados para a criptografia (Chave Externa)    
        /// </summary>    
        private byte[] bIV =
        { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18,
        0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };

        /// <summary>    
        /// Metodo de criptografia de valor    
        /// </summary>    
        /// <param name="text">valor a ser criptografado</param>    
        /// <returns>valor criptografado</returns>
        public string Encrypt(string text)
        {
            try
            {
                // Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(text))
                {
                    // Cria instancias de vetores de bytes com as chaves               
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = new UTF8Encoding().GetBytes(text);

                    // Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    // Define o tamanho da chave "256 = 8 * 32"               
                    // Lembre-se: chaves possíves:               
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)               
                    rijndael.KeySize = 256;

                    // Cria o espaço de memória para guardar o valor criptografado:               
                    MemoryStream mStream = new MemoryStream();
                    // Instancia o encriptador                
                    CryptoStream encryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateEncryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    // Faz a escrita dos dados criptografados no espaço de memória
                    encryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.               
                    encryptor.FlushFinalBlock();
                    // Pega o vetor de bytes da memória e gera a string criptografada               
                    return Convert.ToBase64String(mStream.ToArray());
                }
                else
                {
                    // Se a string for vazia retorna nulo               
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Se algum erro ocorrer, dispara a exceção           
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }

        /// <summary>    
        /// Pega um valor previamente criptografado e retorna o valor inicial
        /// </summary>    
        /// <param name="text">texto criptografado</param>    
        /// <returns>valor descriptografado</returns>    
        public string Decrypt(string text)
        {
            try
            {
                // Se a string não está vazia, executa a criptografia          
                if (!string.IsNullOrEmpty(text))
                {
                    // Cria instancias de vetores de bytes com as chaves               
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = Convert.FromBase64String(text);

                    // Instancia a classe de criptografia Rijndael               
                    Rijndael rijndael = new RijndaelManaged();

                    // Define o tamanho da chave "256 = 8 * 32"               
                    // Lembre-se: chaves possíves:               
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)               
                    rijndael.KeySize = 256;

                    // Cria o espaço de memória para guardar o valor DEScriptografado:              
                    MemoryStream mStream = new MemoryStream();

                    // Instancia o Decriptador                
                    CryptoStream decryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateDecryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    // Faz a escrita dos dados criptografados no espaço de memória  
                    decryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.               
                    decryptor.FlushFinalBlock();
                    // Instancia a classe de codificação para que a string venha de forma correta        
                    UTF8Encoding utf8 = new UTF8Encoding();
                    // Com o vetor de bytes da memória, gera a string descritografada em UTF8      
                    return utf8.GetString(mStream.ToArray());
                }
                else
                {
                    // Se a string for vazia retorna nulo               
                    return null;
                }
            }
            catch (Exception ex)
            {
                // Se algum erro ocorrer, dispara a exceção           
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }

        #endregion

        #region Criptografia XML

        public static string CryptoV(string palavra)
        {
            try
            {
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = Encoding.ASCII.GetBytes("AAABBBCCCDDDEEEFFFGGGHHH");
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                byte[] dados = Encoding.GetEncoding("ISO-8859-1").GetBytes(palavra);
                ICryptoTransform crypto = tdes.CreateEncryptor();
                byte[] dadosEnc = crypto.TransformFinalBlock(dados, 0, dados.Length);
                return Convert.ToBase64String(dadosEnc);
            }
            catch
            {
            }

            return "";

            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();            
            //byte[] byteStr = Encoding.GetEncoding("ISO-8859-1").GetBytes(var);
            //byte[] byteEncriptada = rsa.Encrypt(byteStr, false);
            //return Encoding.GetEncoding("ISO-8859-1").GetString(byteEncriptada);            
        }

        public static string DecryptoV(string palavraCodificada)
        {
            try
            {
                if (string.IsNullOrEmpty(palavraCodificada.Trim()))
                    return string.Empty;

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = Encoding.ASCII.GetBytes("AAABBBCCCDDDEEEFFFGGGHHH");
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;

                byte[] dados = Convert.FromBase64String(palavraCodificada);
                ICryptoTransform crypto = tdes.CreateDecryptor();
                byte[] dadosEnc = crypto.TransformFinalBlock(dados, 0, dados.Length);
                return Encoding.GetEncoding("ISO-8859-1").GetString(dadosEnc);
            }
            catch (Exception exp)
            {
                //FileLog.GravarLog(exp, "Erro de segurança DecryptoV.");
            }

            return "";

            //RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            //byte[] byteEncriptadaConvertida = Encoding.GetEncoding("ISO-8859-1").GetBytes(var);
            //byte[] byteDecriptada = rsa.Decrypt(byteEncriptadaConvertida, false);
            //return Encoding.GetEncoding("ISO-8859-1").GetString(byteDecriptada);
        }

        #endregion
    }
}

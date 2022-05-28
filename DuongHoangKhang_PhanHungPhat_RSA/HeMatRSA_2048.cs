using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace DuongHoangKhang_PhanHungPhat_RSA
{
    class HeMatRSA_2048
    {
        RSACryptoServiceProvider csp = new RSACryptoServiceProvider(1024);
        RSAParameters publicKey, privateKey;

        public HeMatRSA_2048()
        {
            publicKey = csp.ExportParameters(false);
            privateKey = csp.ExportParameters(true);
        }

        public string GetPublicKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            //var xs = new string(typeof(RSAParameters));
            xs.Serialize(sw, publicKey);
            return sw.ToString();
        }

        public string GetPrivateKey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            //var xs = new string(typeof(RSAParameters));
            xs.Serialize(sw, privateKey);
            return sw.ToString();
        }

        public string Mahoa(string text)
        {
            csp.ImportParameters(publicKey);
            var data = Encoding.UTF8.GetBytes(text);
            var dataEncryption = csp.Encrypt(data, false);
            return Convert.ToBase64String(dataEncryption);
        }

        public string GiaiMa(string text)
        {
            var data = Convert.FromBase64String(text);
            csp.ImportParameters(privateKey);
            var dataDecryption = csp.Decrypt(data, false);
            return Encoding.UTF8.GetString(dataDecryption);
        }
    }
}

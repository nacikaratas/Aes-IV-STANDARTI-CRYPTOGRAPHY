using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AesSifreleme
{
    class aesSifreleveCoz
    {
        private const string AES_IV = @"!&+QWSDF!123127+";
        private string aesAnahtar = @"QQsaw!257()%%ert";
        AesCryptoServiceProvider aesSaglayici = new AesCryptoServiceProvider();
        public string AESsifrele(string metin)
        {
            
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;

            aesSaglayici.IV=Encoding.UTF8.GetBytes(AES_IV);
            aesSaglayici.Key=Encoding.UTF8.GetBytes(aesAnahtar);
            aesSaglayici.Mode=CipherMode.CBC;
            aesSaglayici.Padding=PaddingMode.PKCS7;

            byte[] kaynak=Encoding.Unicode.GetBytes(metin);
            using (ICryptoTransform sifreleme=aesSaglayici.CreateEncryptor())
            {
                byte[] sifrelenmisMetin=sifreleme.TransformFinalBlock(kaynak,0,kaynak.Length);
                return Convert.ToBase64String(sifrelenmisMetin);
            }
        }
        public string AESsifre_Coz(string sifreliMetin)
        {
            aesSaglayici.BlockSize = 128;
            aesSaglayici.KeySize = 128;
           
            aesSaglayici.IV = Encoding.UTF8.GetBytes(AES_IV);
            aesSaglayici.Key = Encoding.UTF8.GetBytes(aesAnahtar);
            aesSaglayici.Mode = CipherMode.CBC;
            aesSaglayici.Padding = PaddingMode.PKCS7;

            byte[] kaynak=Convert.FromBase64String(sifreliMetin);
            using (ICryptoTransform sifreCozme=aesSaglayici.CreateDecryptor())
            {
                byte[] cozulmusMetin=sifreCozme.TransformFinalBlock(kaynak,0,kaynak.Length);
                return Encoding.Unicode.GetString(cozulmusMetin);
            }
        }
    }
}

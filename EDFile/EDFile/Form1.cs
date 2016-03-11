using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Web;

namespace EDFile
{
    public partial class Form1 : Form
    {
        //byte[] pwd = Encoding.UTF8.GetBytes("1qazXDR%68");
        static byte[] pwd = {0xA1, 0xA2, 0xA3, 0xA4};
        //string strPwd = BitConverter.ToString().Replace("-", " ");
        //1.firehole 2.jtsghtqb
        public Form1()
        {
            InitializeComponent();
        }

        ///<summary><![CDATA[字符串DES加密函数]]></summary>
        ///<param name="str"><![CDATA[被加密字符串 ]]></param>
        ///<param name="key"><![CDATA[密钥 ]]></param> 
        ///<returns><![CDATA[加密后字符串]]></returns>   
        public static string Encode(string str, string key)
        {
            try
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                //byte[] bytes = Encoding.Default.GetBytes(str);
                byte[] bytes = Encoding.GetEncoding("utf-8").GetBytes(str);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                StringBuilder builder = new StringBuilder();
                foreach (byte num in stream.ToArray())
                {
                    builder.AppendFormat("{0:X2}", num);
                }
                stream.Close();
                return builder.ToString();
            }
            catch (Exception) { return "xxxx"; }
        }
        ///<summary><![CDATA[字符串DES解密函数]]></summary>
        ///<param name="str"><![CDATA[被解密字符串 ]]></param>
        ///<param name="key"><![CDATA[密钥 ]]></param> 
        ///<returns><![CDATA[解密后字符串]]></returns>   
        public static string Decode(string str, string key)
        {
            try
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                byte[] buffer = new byte[str.Length / 2];
                for (int i = 0; i < (str.Length / 2); i++)
                {
                    int num2 = Convert.ToInt32(str.Substring(i * 2, 2), 0x10);
                    buffer[i] = (byte)num2;
                }
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                stream.Close();
                return Encoding.GetEncoding("GB2312").GetString(stream.ToArray());
            }
            catch (Exception) { return ""; }
        }


        static void EncryptFile(string sInputFilename,string sOutputFilename,string sKey)
        {
            FileStream fsInput = new FileStream(sInputFilename,FileMode.Open,FileAccess.Read);
            FileStream fsEncrypted = new FileStream(sOutputFilename,FileMode.Create,FileAccess.Write);
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey.Substring(0,8));
            ICryptoTransform desencrypt = DES.CreateEncryptor();
            CryptoStream cryptostream = new CryptoStream(fsEncrypted,desencrypt,CryptoStreamMode.Write);
            byte[] bytearrayinput = new byte[fsInput.Length];
            fsInput.Read(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
            cryptostream.Close();
            fsInput.Close();
            fsEncrypted.Close();
        }

        static void DecryptFile(string sInputFilename,string sOutputFilename,string sKey)
        {
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DES.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
            //Set initialization vector.
            DES.IV = ASCIIEncoding.ASCII.GetBytes(sKey);

            //Create a file stream to read the encrypted file back.
            FileStream fsread = new FileStream(sInputFilename,FileMode.Open,FileAccess.Read);
            //Create a DES decryptor from the DES instance.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();
            //Create crypto stream set to read and do a 
            //DES decryption transform on incoming bytes.
            CryptoStream cryptostreamDecr = new CryptoStream(fsread,desdecrypt,CryptoStreamMode.Read);
            //Print the contents of the decrypted file.

            StreamWriter fsDecrypted = new StreamWriter(sOutputFilename);
            fsDecrypted.Write(new StreamReader(cryptostreamDecr).ReadToEnd());
            fsDecrypted.Flush();
            fsDecrypted.Close();
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_inifile.Text = openFileDialog1.FileName;
            }
        }

        private void btn_DESEncrypt_Click(object sender, EventArgs e)
        {
            String strOutputFilename = tb_inifile.Text + "_E";
            try
            {
                StreamReader sr = new StreamReader(tb_inifile.Text);
                String strIn = sr.ReadToEnd();
                String strOut = Encode(strIn, "1qazXDR%68");
                StreamWriter sw = new StreamWriter(strOutputFilename, false);
                sw.Write(strOut);
                sw.Flush();
                sr.Close();
                sw.Close();
                MessageBox.Show("加密成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_DESDecrypt_Click(object sender, EventArgs e)
        {
            //String strOut = Decode("F7A65602F2D10A4B", "com.sina.weibo.security.password.d7af3082d815945ff47ae58647bd9436");
            String strOutputFilename = tb_inifile.Text;
            String strDOutputFilename = tb_inifile.Text + "_D";
            try
            {
                StreamReader sr = new StreamReader(strOutputFilename);
                String strIn = sr.ReadToEnd();
                String strOut = Decode(strIn, "1qazXDR%68");
                StreamWriter sw = new StreamWriter(strDOutputFilename, false);
                sw.Write(strOut);
                sw.Flush();
                sr.Close();
                sw.Close();
                MessageBox.Show("解密成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public byte[] Encrypt(byte[] password, byte[] plainString)
        {
            byte[] K = password;
            int[] S = new int[256];//状态矢量S
            int[] T = new int[256];//临时矢量T
            //  初始化状态矢量S,同时生成临时矢量T 
            for (int i = 0; i < 256; i++)
            {
                S[i] = i;
                T[i] = K[i % K.Length];
            }
            //用T使S置换
            int j = 0;
            for (int i = 0; i < 256; i++)
            {
                j = (j + (int)S[i] + (int)T[i]) % 256;
                swap(S[i], S[j]);
            }
            int i1 = 0, j1 = 0;
            int c = 0;
            int t;
            byte k;//密钥流的当前字节
            byte[] P = plainString;
            byte[] C = new byte[P.Length];
            while (c < P.Length)
            {
                i1 = (i1 + 1) % 256;
                j1 = (j1 + S[i1]) % 256;
                swap(S[i1], S[j1]);
                t = ((S[i1] + S[j1]) % 256);
                k = (byte)S[t];
                C[c] = (byte)(k ^ P[c]);
                c++;
            }
            return C;
        }

        private void swap(int x, int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        private void btn_RC4Encrypt_Click(object sender, EventArgs e)
        {
            String strDInputFilename = tb_inifile.Text;
            String strDOutputFilename = strDInputFilename.Substring(0, strDInputFilename.LastIndexOf(".")) + "_ENC.txt";
            try
            {
                FileStream fsData = new FileStream(tb_inifile.Text, FileMode.Open);
                byte[] fileData = new byte[fsData.Length];
                fsData.Read(fileData, 0, (int)fsData.Length);
                fsData.Close();
                byte[] rc4Data = new RC4Crypto().EncryptEx(fileData, pwd);
                string base64EncodedString = System.Convert.ToBase64String(rc4Data);
                byte[] encryptData = System.Text.Encoding.UTF8.GetBytes(base64EncodedString);
                FileStream fs = new FileStream(strDOutputFilename, FileMode.Create);
                fs.Write(encryptData, 0, encryptData.Length);
                fs.Close();
                MessageBox.Show("加密成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_RC4Decrypt_Click(object sender, EventArgs e)
        {
            String strDInputFilename = tb_inifile.Text;
            String strDOutputFilename = strDInputFilename.Substring(0, strDInputFilename.LastIndexOf(".")) + "_DEC.txt";
            try
            {
                FileStream fsData = new FileStream(tb_inifile.Text, FileMode.Open);
                byte[] fileData = new byte[fsData.Length];
                fsData.Read(fileData, 0, (int)fsData.Length);
                fsData.Close();
                string base64Decodedstring = System.Text.Encoding.UTF8.GetString(fileData);
                byte[] base64EncodedBytes = System.Convert.FromBase64String(base64Decodedstring);
                byte[] EncryptData = new RC4Crypto().DecryptEx(base64EncodedBytes, pwd);
                FileStream fs = new FileStream(strDOutputFilename, FileMode.Create);
                fs.Write(EncryptData, 0, EncryptData.Length);
                fs.Close();
                MessageBox.Show("解密成功!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_en_Click(object sender, EventArgs e)
        {
            tb_out.Text = Encode(tb_in.Text, "1qazXDR%68");
        }

        /// <summary>
        /// 计算字符串的MD5值
        /// </summary>
        /// <param name="strInput"></param>
        /// <returns></returns>
        public static string MD5(string strInput)
        {
            string strMD5 = "";
            if (String.IsNullOrEmpty(strInput))
                return strMD5;
            try
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] data = System.Text.Encoding.Default.GetBytes(strInput);//将字符编码为一个字节序列
                byte[] md5data = md5.ComputeHash(data);//计算data字节数组的哈希值
                md5.Clear();
                for (int i = 0; i < md5data.Length; i++)
                {
                    strMD5 += md5data[i].ToString("x").PadLeft(2, '0');
                }
            }
            catch (System.Exception ex)
            {
                throw;
            }
            return strMD5;
        }


        public static string MyUrlDeCode(string str, Encoding encoding)
        {
            if (encoding == null)
            {
                Encoding utf8 = Encoding.UTF8;
                //首先用utf-8进行解码                    
                string code = HttpUtility.UrlDecode(str.ToUpper(), utf8);
                //将已经解码的字符再次进行编码.
                string encode = HttpUtility.UrlEncode(code, utf8).ToUpper();
                if (str == encode)
                    encoding = Encoding.UTF8;
                else
                    encoding = Encoding.GetEncoding("gb2312");
            }
            return HttpUtility.UrlDecode(str, encoding);
        }

        private void btn_de_Click(object sender, EventArgs e)
        {
            tb_out.Text = MyUrlDeCode(Decode(tb_in.Text, "1qazXDR%68"), Encoding.UTF8);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
              if (e.Data.GetDataPresent(DataFormats.FileDrop))
                 e.Effect = DragDropEffects.Link;
              else 
                   e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            tb_inifile.Text = path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_in.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_out.Text = "";
        }

    }
}

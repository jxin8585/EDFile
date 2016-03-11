using System;
using System.Globalization;
using System.Collections;
using System.Text;

namespace EDFile
{
    public class RC4Engine
    {
        #region Costructor

        public RC4Engine()
        {
        }

        #endregion

        // #region Public Method

        /// <summary>
        /// Encript InClear Text using RC4 method using EncriptionKey
        /// Put the result into CryptedText 
        /// </summary>
        /// <returns>true if success, else false</returns>

        public byte[] Encrypt(byte[] input, int len)
        {
            // 
            // Output byte array
            //
            byte[] output = new byte[len];

            //
            // Local copy of m_nBoxLen
            //
            byte[] n_LocBox = new byte[m_nBoxLen];
            this.m_nBox.CopyTo(n_LocBox, 0);

            //
            // Run Alghoritm
            //
            long i = 0;
            long j = 0;
            for (long offset = 0; offset < len; offset++)
            {
                i = (i + 1) % m_nBoxLen;
                j = (j + n_LocBox[i]) % m_nBoxLen;
                byte temp = n_LocBox[i];
                n_LocBox[i] = n_LocBox[j];
                n_LocBox[j] = temp;
                byte a = input[offset];
                byte b = n_LocBox[(n_LocBox[i] + n_LocBox[j]) % m_nBoxLen];
                output[offset] = (byte)((int)a ^ (int)b);
            }

            return output;
        }


        #region Prop definitions
        /// <summary>
        /// Get or set Encryption Key
        /// </summary>
        public void MakeKey(string key)
        {
            MakeKey(Encoding.ASCII.GetBytes(key), key.Length);
        }

        public void MakeKey(byte[] key, int len)
        {
            if (len == 0)
                return;

            //
            // Populate m_nBox
            //
            long KeyLen = len;

            //
            // First Loop
            //
            for (long count = 0; count < m_nBoxLen; count++)
            {
                this.m_nBox[count] = (byte)count;
            }

            //
            // Second Loop
            //
            long index2 = 0;
            for (long count = 0; count < m_nBoxLen; count++)
            {
                index2 = (index2 + m_nBox[count] + key[count % KeyLen]) % m_nBoxLen;
                byte temp = m_nBox[count];
                m_nBox[count] = m_nBox[index2];
                m_nBox[index2] = temp;
            }

        }

        #endregion

        #region Private Fields

        //
        // It is related to Encryption Key
        //
        protected byte[] m_nBox = new byte[m_nBoxLen];
        //
        // Len of nBox
        //
        static public long m_nBoxLen = 256;

        #endregion

    }
}

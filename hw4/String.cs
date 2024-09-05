using System;


namespace hw4
{
    internal class String
    {
        public char[] str { get; set; }
        public int Length { get; private set; }
        public String(char[] str)
        {
            this.str = str;
            this.Length = str.Length;
        }

        public char StartWith() => str[0];
        public char EndWith() => str[str.Length - 1];

        public char[] Substring(int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex < 0)
            {
                throw new Exception("Error");
            }

            int length = endIndex - startIndex + 1;
            char[] result = new char[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = this.str[startIndex + i];
            }

            return result;
        }

        public void Remove(int startIndex, int endIndex)
        {
            if (startIndex < 0 || endIndex < 0)
            {
                throw new Exception("Error");
            }
            int newLength = this.Length - (endIndex - startIndex + 1);
            char[] result = new char[newLength];
            for (int i = 0, j = 0; i < this.Length; i++) {
                if(i < startIndex || i > endIndex)
                {
                    result[j++] = this.str[i];
                }
            }
            this.Length = newLength;
            this.str = result;
        }

        public void RemoveAll()
        {
            this.str = new char[0];
            this.Length = 0;
        }



        public void Concat(char[] str1, char[] str2)
        {
            int newLength = str1.Length + str2.Length;
            char[] result = new char[newLength];

            for (int i = 0; i < str1.Length; i++)
            {
                result [i] = str1[i];
            }
            for (int i = 0; i < str2.Length; i++) {
                result[str1.Length + i] = str2[i];
            }
            this.Length = newLength;
            this.str = result;
        }

        public void Replace(char[] oldValue, char[] newValue)
        {
            string original = new string(this.str);
            string oldStr = new string(oldValue);
            string newStr = new string(newValue);

            string newString = original.Replace(oldStr, newStr);

            this.str = newString.ToCharArray();
            this.Length = this.str.Length;
        }


        public void Trim(char ch)
        {
            int newLength = 0;
            for (int i = 0; i < this.Length; i++) {
                if (this.str[i] != ch) {
                    newLength++;
                }
            }
            char[] result = new char[newLength];
            int index = 0;
            for(int i = 0; i < this.Length; i++) {
                if (this.str[i] != ch){
                    result[index++] = str[i]; 
                }
            }
            this.str = result;
            this.Length = result.Length;
        }


        public bool CompareTo(char[] str1, char[] str2)
        {
            if(str1.Length != str2.Length) return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if(str1[i] != str2[i]) return false;
            }
            return true;
        }

        public void showString()
        {
            for (int i = 0; i < this.Length; i++)
            {
                Console.Write(this.str[i]);
            }
        }
    }
}

using System;
using System.Runtime.InteropServices;

namespace PassGen
{

    public partial class PassGen : Form
    {

        public PassGen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pw = CreateRandomPassword();

            //Checks if the create method was faulty
            if (pw != "")
            {
                pwd.Text = pw;
                Clipboard.SetText(pw);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pw = pwd.Text;
            string strangeletters = "!§$%&/()=?_:;><|+#{}";
            //Time to redirect to Password box
            Thread.Sleep(2000);
            foreach (char c in pw)
            {
                if (strangeletters.Contains(c.ToString()))
                {
                    writeKey("{" + c.ToString() + "}");
                }
                else
                {
                    writeKey(c.ToString());
                }
            }
        }

        void writeKey(string key)
        {
            SendKeys.SendWait(key);
        }

        private string CreateRandomPassword()
        {
            try
            {
                //String of all ASCI characters
                var chars = " !\"#$%&\\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[]^_`abcdefghijklmnopqrstuvwxyz{|}~";

                //The length of the password
                var stringChars = new char[int.Parse(textBox1.Text)];
                var random1 = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    //pick random char from string
                    stringChars[i] = chars[random1.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                return finalString;
            }
            catch (Exception e)
            {
                // Error window is shown
                Error error = new Error();
                error.Show();
                return "";
            }
        }
    }
}
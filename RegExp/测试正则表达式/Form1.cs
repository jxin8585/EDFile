using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 测试正则表达式
{
    public partial class Form1 : Form
    {
        private List<String> strList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            textBoxHelp.Text = HelpString.HelpText;

            String str = "";

            str = @"(?:<[iI][mM][gG]\s+([^>]*\s*)?src\s*=\s*(?:""(?<1>[/\a-z0-9_][^""]*)""|'(?<1>[/\a-z0-9_][^']*)'|(?<1>[/\a-z0-9_]\S*))(\s[^>]*)?>)|(?:<[aA]\s+([^>]*\s*)?href\s*=\s*(?:""(?<1>[/\a-z0-9_][^""]*)""|'(?<1>[/\a-z0-9_][^']*)'|(?<1>[/\a-z0-9_]\S*))(\s[^>]*)?>)";
            comboBox1.Items.Add("匹配Href和Src链接");
            strList.Add(str);

            str = @"<a[\s]+[^>]*?href[\s]?=[\s""']*(.*?)[""']*.*?>([^<]+|.*?)?<\/a>";
            comboBox1.Items.Add("匹配Href链接");
            strList.Add(str);

            str = @"<[iI][mM][gG][\s]+[^>]*?src[\s]?=[\s""']*(.*?)[""']*.*?>([^<]+|.*?)?<\/a>";
            comboBox1.Items.Add("匹配Src链接");
            strList.Add(str);

            str =
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}年\d{1,2}月\d{1,2}日)|" +
                @"(\d{1,2}月\d{1,2}日)|" +
                @"(\d{1,2}/\d{1,2}/\d{2,4})|" +
                @"(\d{2,4}/\d{1,2}/\d{1,2})|" +
                @"(\d{2,4}-\d{1,2}-\d{1,2})|" +
                @"(\d{2,4}\.\d{1,2}\.\d{1,2})|" +

                @"(\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}:\d{1,2})";
            comboBox1.Items.Add("匹配日期时间或日期或时间");
            strList.Add(str);

            str =
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})";

            comboBox1.Items.Add("匹配日期+时间");
            strList.Add(str);

            str =
                @"(\d{2,4}年\d{1,2}月\d{1,2}日)|" +
                @"(\d{1,2}月\d{1,2}日)|" +

                @"(\d{2,4}-\d{1,2}-\d{1,2})|" +

                @"(\d{2,4}/\d{1,2}/\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}/\d{2,4})|" +

                @"(\d{2,4}\.\d{1,2}\.\d{1,2})";

            comboBox1.Items.Add("只匹配日期(不含时间)");
            strList.Add(str);

            //【2010年5月19日16:30:50】
            str =
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}年\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}月\d{1,2}日\s*\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}-\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}-\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}/\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}/\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{2,4}\.\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}\.\d{1,2}\s\d{1,2}:\d{1,2})|" +

                @"(\d{2,4}年\d{1,2}月\d{1,2}日)|" +
                @"(\d{1,2}月\d{1,2}日)|" +
                @"(\d{1,2}/\d{1,2}/\d{2,4})|" +
                @"(\d{2,4}/\d{1,2}/\d{1,2})|" +
                @"(\d{2,4}-\d{1,2}-\d{1,2})|" +
                @"(\d{2,4}\.\d{1,2}\.\d{1,2})|" +

                @"(\d{1,2}:\d{1,2}:\d{1,2})|" +
                @"(\d{1,2}:\d{1,2})|" +

                @"([-]+)|" +
                @"([a-zA-Z]+)|" +
                @"([0-9]+)|" +
                @"([^a-zA-Z\s])";
            comboBox1.Items.Add("统计字数(日期时间为整体)");
            strList.Add(str);

            str = @"charset\W+?(?<var>[\w-]{1,})\W*?";
            comboBox1.Items.Add("直接匹配Charset");
            strList.Add(str);

            str = @"<meta\s+[^><]*?charset\W+?(?<var>[\w-]{1,})\W*?";
            comboBox1.Items.Add("匹配meta中的Charset");
            strList.Add(str);

            str = @"<meta\s+[^><]*?>";
            comboBox1.Items.Add("匹配meta");
            strList.Add(str);

            str = "^[a-zA-Z]:(((\\\\(?! )[^\\\\/:*?\"<>|]+)+\\\\?)|(\\\\))\\s*$";
            comboBox1.Items.Add("匹配文件路径");
            strList.Add(str);

            //MessageBox.Show(match.Groups["var"].Value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String strRegex = textBox1.Text;
                Regex reg;

                //分析正则式中的变量：
                List<String> listorvars = new List<String>();
                Regex reg_matchvarstring = new Regex("\\(\\?<(?<varname>\\w+?)>", RegexOptions.Singleline);
                MatchCollection mvars = reg_matchvarstring.Matches(strRegex);
                foreach (Match v in mvars)
                {
                    listorvars.Add(v.Groups["varname"].Value.Trim());
                }


                if (checkBox1.Checked)
                {
                    reg = new Regex(strRegex, RegexOptions.Singleline | RegexOptions.IgnoreCase);
                }
                else
                {
                    reg = new Regex(strRegex, RegexOptions.IgnoreCase);
                }

                String strInput = textBox2.Text;
                String strOutput = "";
                String strOutputVars = "";

                //匹配多条：
                MatchCollection matches = reg.Matches(strInput);
                int nCount = matches.Count;
                strOutput = "匹配到结果数：" + nCount.ToString() + "\r\n";
                foreach (Match match in matches)
                {
                    strOutput += match.Value + "\r\n\r\n";
                    if (listorvars.Count > 0)
                    {
                        foreach (String varname in listorvars)
                        {
                            strOutputVars += "【" + varname + "】: " + match.Groups[varname].Value + "\r\n\r\n";
                        }
                        strOutputVars += "-------------------------------------\r\n";
                    }
                }

                //只匹配单条：
                //strOutput = reg.Match(strInput).Value;

                textBox3.Text = strOutput;
                textBox4.Text = strOutputVars;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace);
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            String str = Clipboard.GetText();
            textBox2.Text = str;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = strList[comboBox1.SelectedIndex];
            }
            catch (System.Exception ex)
            {

            }
        }
    }
}

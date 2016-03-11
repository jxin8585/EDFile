using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 测试正则表达式
{
    public class HelpString
    {
        public static String HelpText=
            "正则表达式语法" + "\r\n" +
            @"-------------------------------------------------------------------------------------"+"\r\n"+
            @"\d    数字（0~9）"+"\r\n"+
            @"\D    非数字"+"\r\n"+
            @"\w    任意单字符等效于[a-zA-Z_0-9]"+"\r\n"+
            @"\W    非单字符等效于[^a-zA-Z_0-9]"+"\r\n"+
            @"\s    空白字符等效于[ \f\n\r\t\v],注意在\f前有一个空格"+"\r\n"+
            @"\S    非空字符等效于[^ \f\n\r\t\v]"+"\r\n"+
            @".     除\n外的任意字符"+"\r\n"+
            @"[…]   括号中任意字符"+"\r\n"+
            @"[^…]  非[]内所列出的字符"+"\r\n"+
            @"[x-y] 匹配字符范围中的任一字符 "+"\r\n"+
            @"-------------------------------------------------------------------------------------"+"\r\n"+
            @"重复匹配语法："+"\r\n"+
            @"{n}          n次字符"+"\r\n"+
            @"{n,}         n次和n次以上"+"\r\n"+
            @"{n,m}        n次上m次下"+"\r\n"+
            @"?            0或1次"+"\r\n"+
            @"+            一次或多次"+"\r\n"+
            @"*            0次以上"+"\r\n"+
            @"-------------------------------------------------------------------------------------"+"\r\n"+
            @"字符定位语法："+"\r\n"+
            @"^           定位后面模式开始位置                    "+"\r\n"+
            @"$           前面模式位于字符串末端                    "+"\r\n"+
            @"\A          前面模式开始位置                    "+"\r\n"+
            @"\z          前面模式结束位置                    "+"\r\n"+
            @"\Z          前面模式结束位置(换行前)                    "+"\r\n"+
            @"\b          一个单词边界                    "+"\r\n"+
            @"\B          一个非单词边界                    "+"\r\n"+
            @"-------------------------------------------------------------------------------------"+"\r\n"+
            @"转义匹配语法："+"\r\n"+
            @"\+实际字符   \ . * + ? | ( ) { }^ $    例如：\\匹配字符“\”"+"\r\n"+
            @"\n           换行                    "+"\r\n"+
            @"\r           回车                    "+"\r\n"+
            @"\t           水平制表符                    "+"\r\n"+
            @"\v           垂直制表符                    "+"\r\n"+
            @"\f           换页                    "+"\r\n"+
            @"\nnn         一个8进制ASCII                    "+"\r\n"+
            @"\xnn         一个16进制ASCII                    "+"\r\n"+
            @"\unnnn       4个16进制的Uniode            "+"\r\n"+
            @"\c+大写字母  Ctrl-大写字母,例如：\cS-匹配Ctrl+S"+"\r\n"+
            @"注意：这些字符是特殊字符，如要匹配一定要加上转义斜杠 $ ( ) * + . [  ? \ ^ { | " + "\r\n" +
            @"-------------------------------------------------------------------------------------"+"\r\n"+
            @""+
            "\r\n"+"C#代码："+"\r\n"+"\r\n"+
            "  String strRegex =\"<a href=['\\\"]?(?<varlinkurl>.*?)['\\\"]?.*?>(?<varlinktitle>.*?)</a>\";"+"\r\n"+
            "  Regex reg = new Regex(strRegex, RegexOptions.Singleline | RegexOptions.IgnoreCase | RegexOptions.Compiled);"+"\r\n"+
            ""+"\r\n"+
            "  //匹配多条："+"\r\n"+
            "  MatchCollection matchcollection = reg.Matches(strHtml);"+"\r\n"+
            "  nAllResultCount = matchcollection.Count;"+"\r\n"+
            "  foreach (Match m in matchcollection)"+"\r\n"+
            "  {"+"\r\n"+
            "      String str1 = m.Groups[\"varlinkurl\"].Value;"+"\r\n"+
            "      String str2 = m.Groups[\"varlinktitle\"].Value;"+"\r\n"+
            "  }"+"\r\n";
    }
}

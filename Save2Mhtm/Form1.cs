using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace Save2Mhtm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartSave_Click(object sender, EventArgs e)
        {
            new Thread(() => this.Save2Mhtm()) { IsBackground = true }.Start();
            btnStartSave.Text = "正在操作";
        }
        


        private void Save2Mhtm()
        {
            int count = 0;

            string url = "";
            string titleStr = "";
            string path = "";

            //设定要下载到的路径
            if (tBoxfilePath.Text.Trim() == "" || !Directory.Exists(tBoxfilePath.Text.Trim()))
            {
                path = "downloads";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            else { path = tBoxfilePath.Text.Trim(); }


            //遍历url，下载mhtml
            string[] lines = tBoxURL.Lines; //保存行，并记录，等待使用输出

            //int countall = 0;
            int counterror = 0;
            for (int i = 0; i < tBoxURL.Lines.Length; i++)
            {
                url = tBoxURL.Lines[i].ToString();


                titleStr = GetTitle(url);

                if (titleStr == "")
                {
                    titleStr = count.ToString() + ".mhtml";
                }
                string fileSaveName = Path.Combine(path, titleStr+".mhtml");

                Chilkat.Mht mht = new Chilkat.Mht();

                bool mhtStr = mht.GetAndSaveMHT(url, fileSaveName);
                if (mhtStr == true)
                {
                    string success_url = url + "    -- " + titleStr + "  -- ok";
                    lines[i] = success_url;
                }
                else { string error_url = url + "  !!!Save Error!!!"; lines[i] = error_url; counterror++; }
            }            
            tBoxURL.Lines = lines;
            btnStartSave.Text = "开始保存";
            lbl1.Text = "总计：" + tBoxURL.Lines.Length.ToString() + "  错误：" + counterror.ToString();



        }

        private string GetTitle(string url)
        {
            string title = "";

            WebClient client = new WebClient();
            client.Headers["User-Agent"] = "Mozilla/5.0 (Windows; U; MSIE 9.0; Windows NT 9.0; en-US)";
            Byte[] pageData = client.DownloadData(url);
            string pageHtml = Encoding.UTF8.GetString(pageData);

            Regex regx = new Regex("<title>(.*?)</title>");

            try
            {
                string titleregx = regx.Match(pageHtml).Value; //<title>这是标题</title>
                string titleClear = titleregx.Substring(7, titleregx.Length - 7 - 8);
                string[] dd ={"◎", "■", "●", "№", "↑", "→", "↓" +
"!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "|", "[", "]", "？", "~", "`", "," +
"！", "<", ">", "‰", "→", "←", "↑", "↓", "¤", "§", "＃", "＆", "＆", "＼", "≡", "≠" +
"≈", "∈", "∪", "∏", "∑", "∧", "∨", "⊥", "‖", "‖", "∠", "⊙", "≌", "≌", "√", "∝", "∞", "∮" +
"∫", "≯", "≮", "＞", "≥", "≤", "≠", "±", "＋", "÷", "×", "/" +
"╄", "╅", "╇", "┻", "┻", "┇", "┭", "┷", "┦", "┣", "┝", "┤", "┷", "┷", "┹", "╉", "╇", "【", "】" +
"┌", "├", "┬", "┼", "┍", "┕", "┗", "┏", "┅", "—" +
"〖", "〗", "←", "〓", "☆", "§", "□", "‰", "◇", "＾", "＠", "△", "▲", "＃", "℃", "※", "≈", "￠","/"};
                for (int b = 0; b < dd.Length; b++)
                {
                    string tt = dd[b];
                    titleClear = titleClear.Replace(tt, "");

                }

                return titleClear;
            }
            catch
            { return title; }
                       
        }


    }
}

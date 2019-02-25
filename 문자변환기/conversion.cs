using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 문자변환기
{
    public partial class conversion : Form
    {
        string Before_Text;
        string After_Text;
        string Before_Word;
        string After_Word;

        public conversion()
        {
            InitializeComponent();
        }

        public int size_text(string str_tmp)
        {
            int nRet = 0;
            int _index = 0;

            while (true)
            {
                if(str_tmp[_index] == ' ' && str_tmp[_index + 1] == ' ')
                {
                    nRet = _index - 1;
                    break;
                }

                _index++;
            }
            return nRet;
        }

        private void ConversionButton_Click(object sender, EventArgs e)
        {
            Before_Text = this.BeforeText.Text;
            Before_Word = this.Before.Text;
            After_Word = this.After.Text;

            int Before_Text_size = size_text(Before_Text);

            if (Before_Text_size == 0)
            {
                MessageBox.Show("Text가 존재하지 않습니다.");
                return;
            }



        }
    }
}

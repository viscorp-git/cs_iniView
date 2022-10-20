using System;
using System.Windows.Forms;

namespace IniView
{
    public partial class IniView_F1 : Form
    {
        private IniFile ini = new IniFile("./setup.ini");

        public IniView_F1()
        {
            InitializeComponent();
            IniLoad();   // ini 파일 정보 불러오기
        }

        private void IniLoad()
        {
            edtIniDir.Text = ini.IniReadValue("Last", "IniDir");  // 최근 사용 경로 불러오기
        }


        private void btnIniDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                edtIniDir.Text = folderBrowserDialog1.SelectedPath;
                ini.IniWriteValue("Last", "iniDir", edtIniDir.Text);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            edtFilename.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            edtExposure1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            edtExposure2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            edtChannel1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            edtChannel2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            edtWorkspace.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            edtStream.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnIniSave_Click(object sender, EventArgs e)
        {
            string sFilename;

            sFilename = edtIniDir.Text + "\\" + edtFilename.Text;
            IniFile iniSave = new IniFile(sFilename);

            iniSave.IniWriteValue("Camera", "m_dlExposure1", edtExposure1.Text);
            iniSave.IniWriteValue("Camera", "m_dlExposure2", edtExposure2.Text);
            iniSave.IniWriteValue("Light", "m_dlChannel1", edtChannel1.Text);
            iniSave.IniWriteValue("Light", "m_dlChannel2", edtChannel2.Text);
            iniSave.IniWriteValue("VPDL", "m_strWorkSpacePath", edtWorkspace.Text);
            iniSave.IniWriteValue("VPDL", "m_dlStream", edtStream.Text);

            dataGridView1.Rows.Clear();
            btnIniLoad_Click(sender, e);

        }

        private void btnIniLoad_Click(object sender, EventArgs e)
        {
            string sFilename;
            string m_dlExposure1, m_dlExposure2;
            string m_dlChannel1, m_dlChannel2;
            string m_strWorkSpacePath;
            string m_dlStream;

            dataGridView1.Rows.Clear();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(edtIniDir.Text);



            foreach (var filename in di.GetFiles())
            {
                sFilename = di.FullName + "\\" + filename;
                IniFile iniView = new IniFile(sFilename);
                m_dlExposure1 = iniView.IniReadValue("Camera", "m_dlExposure1");
                m_dlExposure2 = iniView.IniReadValue("Camera", "m_dlExposure2");
                m_dlChannel1 = iniView.IniReadValue("Light", "m_dlChannel1");
                m_dlChannel2 = iniView.IniReadValue("Light", "m_dlChannel2");
                m_strWorkSpacePath = iniView.IniReadValue("VPDL", "m_strWorkSpacePath");
                m_dlStream = iniView.IniReadValue("VPDL", "m_dlStream");

                dataGridView1.Rows.Add(filename, m_dlExposure1, m_dlExposure2, m_dlChannel1, m_dlChannel2, m_strWorkSpacePath, m_dlStream);
            }
        }
    }
}
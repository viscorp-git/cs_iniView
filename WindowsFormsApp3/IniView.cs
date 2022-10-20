using System;
using System.Windows.Forms;

namespace IniView
{
    public partial class IniView_F1 : Form
    {
        private IniFile iniSetup = new IniFile("./setup.ini");  // 최근 사용경로를 저장할 ini파일

        public IniView_F1()
        {
            InitializeComponent();
            IniSetupLoad();   // ini 파일 정보 불러오기
        }

        private void IniSetupLoad()
        {
            edtIniDir.Text = iniSetup.IniReadValue("Last", "IniDir");  // 최근 사용 경로 불러오기
        }

        private void btnIniDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                edtIniDir.Text = folderBrowserDialog1.SelectedPath;
                iniSetup.IniWriteValue("Last", "iniDir", edtIniDir.Text);  // 최근 사용 경로 저장
            }
        }

        // 클릭시 edit창으로 값 가져오기
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

        // Ini파일 저장
        private void btnIniSave_Click(object sender, EventArgs e)
        {
            string sFilename = edtIniDir.Text + "\\" + edtFilename.Text;
            IniFile iniSave = new IniFile(sFilename);

            iniSave.IniWriteValue("Camera", "m_dlExposure1", edtExposure1.Text);
            iniSave.IniWriteValue("Camera", "m_dlExposure2", edtExposure2.Text);
            iniSave.IniWriteValue("Light", "m_dlChannel1", edtChannel1.Text);
            iniSave.IniWriteValue("Light", "m_dlChannel2", edtChannel2.Text);
            iniSave.IniWriteValue("VPDL", "m_strWorkSpacePath", edtWorkspace.Text);
            iniSave.IniWriteValue("VPDL", "m_dlStream", edtStream.Text);

            // 저장 후 갱신하기 위해 Clear하고 다시 불러오기
            dataGridView1.Rows.Clear();
            btnIniLoad_Click(sender, e);
        }

        // 폴더내 ini 파일 불러오기
        private void btnIniLoad_Click(object sender, EventArgs e)
        {
            string sFilename;
            string sExposure1, sExposure2;
            string sChannel1, sChannel2;
            string sWorkSpacePath;
            string sStream;

            dataGridView1.Rows.Clear(); // Grid Clear
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(edtIniDir.Text);  // 폴더내 파일정보
            foreach (var filename in di.GetFiles())  // ini파일 하나씩 읽어와서 Grid에 내용 추가
            {
                sFilename = di.FullName + "\\" + filename;
                IniFile iniLoad = new IniFile(sFilename);

                sExposure1 = iniLoad.IniReadValue("Camera", "m_dlExposure1");
                sExposure2 = iniLoad.IniReadValue("Camera", "m_dlExposure2");
                sChannel1 = iniLoad.IniReadValue("Light", "m_dlChannel1");
                sChannel2 = iniLoad.IniReadValue("Light", "m_dlChannel2");
                sWorkSpacePath = iniLoad.IniReadValue("VPDL", "m_strWorkSpacePath");
                sStream = iniLoad.IniReadValue("VPDL", "m_dlStream");

                dataGridView1.Rows.Add(filename, sExposure1, sExposure2, sChannel1, sChannel2, sWorkSpacePath, sStream);
            }
        }
    }
}
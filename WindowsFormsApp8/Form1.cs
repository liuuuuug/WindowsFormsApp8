using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;

using System.IO;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static SqlConnection conn;

        public static SqlCommand cmd;

        Stream ms;


        private byte[] GetImageBytes(Image image)

        {

            Bitmap bmp = new Bitmap(image);

            MemoryStream mstream = new MemoryStream();

            bmp.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);

            mstream.Seek(0, SeekOrigin.Begin); //及时定位流的开始位置

            byte[] byteData = new Byte[mstream.Length];

            mstream.Position = 0;

            mstream.Read(byteData, 0, byteData.Length);

            mstream.Close();

            return byteData;

        }

        private void Btn_ImgLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg|*.jpg|*.bmp|*.bmp";//指定openFileDialog控件打开的文件格式



            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "*jpg|*.JPG|*.GIF|*.GIF|*.BMP|*.BMP";

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)

            {

                if ((ms = openFileDialog1.OpenFile()) != null)

                {

                    //获取当前选择的图片

                    this.Img_box.Image = Image.FromStream(this.openFileDialog1.OpenFile());

                    //获取当前图片的路径

                    string path = openFileDialog1.FileName.ToString();

                    //将制定路径的图片添加到FileStream类中    

                    FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);

                    //通过FileStream对象实例化BinaryReader对象

                    BinaryReader br = new BinaryReader(fs);

                    //通过BinaryReader类对象的ReadBytes()方法将FileStream类对象转化为二进制数组

                    byte[] imgBytesIn = br.ReadBytes(Convert.ToInt32(fs.Length));
                    Img_box.SizeMode = PictureBoxSizeMode.Zoom;

                }

                else

                {

                    MessageBox.Show("您选择的图片不能被读取或文件类型错误！", "错误 ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }



            }


        }
        private void Form1_Load(object sender, EventArgs e)

        {

            conn = new SqlConnection();

            conn.ConnectionString = @"Data Source=MSSQLSERVER;Initial Catalog=BDProjectt2020;

                                      Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=vs2019;Data Source=.";




        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = GetImageBytes(Img_box.Image);



            string SqlStr = "INSERT INTO DBImg(ID,Name,Img)VALUES(1,'测试图片',@ImgData)";

            SqlCommand cmd = new SqlCommand(SqlStr, conn);

            SqlParameter param = new SqlParameter("ImgData", SqlDbType.VarBinary, imageBytes.Length);


            // 如果数据库关闭，则打开数据库

           

            cmd.Parameters.Add(param);


            if (conn.State == ConnectionState.Closed)

                try { conn.Open(); }

                catch (Exception ex)

                {
                    MessageBox.Show("打开数据库失败，请检查数据设置." + ex.Message, "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }

            cmd.Parameters.Add(param);



            int i = cmd.ExecuteNonQuery();

            MessageBox.Show(i + " 条图片数据保存成功");

        }


    }
    }



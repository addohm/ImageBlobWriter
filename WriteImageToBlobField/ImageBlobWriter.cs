using ImageMagick;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WriteImageToBlobField
{
    public partial class ImageBlobWriter : Form
    {
        /// <summary>
        /// Gets or sets the length of the ImageData object
        /// </summary>
        private int _length;

        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = this.ToByte.Length;
            }
        }

        /// <summary>
        /// Gets the image file as an array of bytes
        /// </summary>
        public byte[] ToByte { get; set; }

        public ImageBlobWriter()
        {
            InitializeComponent();
            tbServer.Text = Properties.Settings.Default.sqlServer;
            tbDatabase.Text = Properties.Settings.Default.sqlDatabase;
            tbTable.Text = Properties.Settings.Default.sqlTable;
            tbField.Text = Properties.Settings.Default.sqlFieldname;
            tbDistinction.Text = Properties.Settings.Default.sqlDistinction;
            tbUsername.Text = Properties.Settings.Default.sqlUsername;
            tbPassword.Text = Properties.Settings.Default.sqlPassword;
            tbFilePath.Text = Properties.Settings.Default.imgFilePath;
            cbUpdate.Checked = Properties.Settings.Default.lastUpdate;
            cbCompress.Checked = Properties.Settings.Default.lastCompress;

            SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder
            {
                DataSource = Properties.Settings.Default.sqlServer,
                InitialCatalog = Properties.Settings.Default.sqlDatabase,
                UserID = Properties.Settings.Default.sqlUsername,
                Password = Properties.Settings.Default.sqlPassword
            };

            Properties.Settings.Default.sqlConnectionString = cb.ToString();

            Properties.Settings.Default.Save();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.sqlServer = tbServer.Text;
                Properties.Settings.Default.sqlDatabase = tbDatabase.Text;
                Properties.Settings.Default.sqlTable = tbTable.Text;
                Properties.Settings.Default.sqlFieldname = tbField.Text;
                Properties.Settings.Default.sqlDistinction = tbDistinction.Text;
                Properties.Settings.Default.sqlUsername = tbUsername.Text;
                Properties.Settings.Default.sqlPassword = tbPassword.Text;
                Properties.Settings.Default.imgFilePath = tbFilePath.Text;
                Properties.Settings.Default.lastUpdate = cbUpdate.Checked;
                Properties.Settings.Default.lastCompress = cbCompress.Checked;

                SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder
                {
                    DataSource = tbServer.Text,
                    InitialCatalog = tbDatabase.Text,
                    UserID = tbUsername.Text,
                    Password = tbPassword.Text
                };
                Properties.Settings.Default.sqlConnectionString = cb.ToString();

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                DialogResult mb = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = @"Image files (*.bmp, *.jpg, *.gif, *.png)|*.bmp;*.jpg;*.gif;*.png|"
                                         + "Document files (*.doc, *.docx, *.pdf)|*.doc;*.docx;*.pdf|"
                                         + "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    tbFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnWriteBlob_Click(object sender, EventArgs e)
        {
            bool checkFields = FieldVerification();
            if (checkFields == true)
            {
                // Read the file bytes and store it in the ToByte property
                this.ToByte = File.ReadAllBytes(tbFilePath.Text);
                string distinction = tbDistinction.Text;

                SqlConnectionStringBuilder cb = new SqlConnectionStringBuilder
                {
                    DataSource = tbServer.Text,
                    InitialCatalog = tbDatabase.Text,
                    UserID = tbUsername.Text,
                    Password = tbPassword.Text
                };

                if (cbCompress.Checked == true)
                {
                    // do some compression magic to ToByte before writing
                    // Read image from file
                    using (MagickImage image = new MagickImage(this.ToByte))
                    {
                        // Sets the output format to jpeg
                        image.Format = MagickFormat.Png;
                        // Create byte array that contains a jpeg file
                        this.ToByte = image.ToByteArray();
                    }
                }

                try
                {
                    using (SqlConnection conn = new SqlConnection(cb.ToString()))
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            string tableName = tbTable.Text;
                            string fieldName = tbField.Text;
                            conn.Open();
                            // Set the correct correct sql command string with parameter
                            // e.g. update TABLE_NAME Set FIELD_NAME = @labelImage where IDENTIFYING_FIELD = something
                            // FIELD_NAME should be a varbinary(max) field
                            if (cbUpdate.Checked == true)
                            {
                                cmd.CommandText = @"update " + tableName + " set " + fieldName + " = @labelImage";

                                if (distinction != "" || distinction != string.Empty)
                                {
                                    cmd.CommandText = cmd.CommandText + " where " + distinction;
                                }
                            }
                            else
                            {
                                cmd.CommandText = @"insert into " + tableName + " values (@labelImage)";
                            }

                            cmd.Parameters.AddWithValue("@labelImage", this.ToByte);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    DialogResult mb = MessageBox.Show("Success!", "Blob Write Successful", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    DialogResult mb = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult mb = MessageBox.Show("You must enter information into all the required fields", "Field Verification", MessageBoxButtons.OK);
            }
        }

        private void TbFilePath_TextChanged(object sender, EventArgs e)
        {
            string path = tbFilePath.Text;

            if (path != string.Empty && Directory.Exists(path))
            {
                using (Image image = Image.FromFile(path))
                {
                    pbImage.Image = image;
                }
            }
        }

        private void CbUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUpdate.Checked == true)
            {
                tbDistinction.Visible = true;
                lbDistinction.Visible = true;
                tbField.Visible = true;
                lbField.Visible = true;
            }
            else
            {
                tbDistinction.Visible = false;
                lbDistinction.Visible = false;
                tbField.Visible = false;
                lbField.Visible = false;
            }
        }

        private bool FieldVerification()
        {
            if (tbServer.Text == string.Empty ||
            tbTable.Text == string.Empty ||
            tbUsername.Text == string.Empty ||
            tbPassword.Text == string.Empty ||
            tbFilePath.Text == string.Empty ||
            tbTable.Text == string.Empty)
            {
                return false;
            }
            else if (cbUpdate.Checked == true)
            {
                if (tbField.Text == string.Empty || tbDistinction.Text == string.Empty)
                {
                    return false;
                }
            }
            return true;

        }

        private void OptionalToolTip(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(tbDistinction, "Used when updating a field.  Optional parameter, if not in use please leave blank.");
        }

        private void UpdateToolTip(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(tbDistinction, "Used when updating a field.  Not optional.");
        }
    }
}
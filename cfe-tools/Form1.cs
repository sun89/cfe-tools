using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace cfe_tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int ENV_OFFSET = 0x14;
        static int MAC_OFFSET = 0xe00;
        static int ENV_STR_LEN = MAC_OFFSET - ENV_OFFSET + 1;


        byte[] env_buf = new byte[0x1000];
        byte[] cfe_buf = null;

        private int count_env_str(ref byte[] buf)
        {
            int count = 0;
            int i;
            int num_zero = 0;
            for (i = 0; i < buf.Length; i++)
            {
                if (buf[i] == 0) //end string symbol
                {
                    num_zero++;
                    if (num_zero == 1) count++;
                    else return count; //end
                }
                else
                {
                    num_zero = 0;
                }
            }
            return 0;
        }

        private int null_str_idx(ref byte[] buf, int start)
        {
            for (int i = start; i < buf.Length; i++)
            {
                if (buf[i] == 0) return i;
            }

            return -1;
        }

        private void extract_env(ref byte[] buf, out byte[][] result, out byte[] lan_mac)
        {
            result = null;
            byte[] env_str = new byte [ENV_STR_LEN ];
            lan_mac = new byte[18];
            Array.Copy(buf, ENV_OFFSET, env_str, 0, ENV_STR_LEN); //Copy env data from 0x1014 to 0x1E000 - 1
            Array.Copy(buf, MAC_OFFSET, lan_mac, 0, 17); //Copy lan mac

            /*StringBuilder sb = new StringBuilder();

            for (int i = 0; i < env_str.Length; i++)
                //sb.Append(Encoding.UTF8.GetString  (env_str)+ " ");
                sb.Append(env_str[i].ToString("X2") + " ");

            textBox2.Text = sb.ToString();
            */
            int start_str = 0;
            int end_str = null_str_idx(ref env_str, 0);
            int num_of_str = count_env_str(ref env_str);
            //MessageBox.Show("Num of env string: " + count_env_str (ref env_str ) + "\n" + "Start: "
            //    +start_str +" End: "+end_str );

            
            result = new byte[100][]; //max 100 string
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new byte[100]; //100 byte max per string
            }

            int idx = 0;
            
            while (start_str < env_str.Length && idx < num_of_str )
            {
                //MessageBox.Show("Start: " + start_str + " End " + end_str +
                //    " [" + env_str[start_str] + "," + env_str[end_str] + "]");
                
                Array.Copy(env_str, start_str, result[idx++], 0, (end_str - start_str)); //extract string
                //Array .Copy (,,,
                start_str = end_str + 1;
                end_str = null_str_idx(ref env_str, end_str + 1);  //Array.IndexOf(env_str, 0, end_str);
                
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonInBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxCFEInput.Text = openFileDialog1.FileName;
        }

        private void buttonOutBrowse_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            textBoxCFEOutput.Text = saveFileDialog1.FileName;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (textBoxCFEInput.Text == "")
            {
                MessageBox.Show(this ,"Wrong input file name.","Input File name",MessageBoxButtons .OK );
                return;
            }

            int i;
            
            try
            {
                cfe_buf = File.ReadAllBytes(textBoxCFEInput.Text);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error: " + ex.ToString (), "Open file error", MessageBoxButtons.OK);
                return;
            }
            
            
            Array.Copy(cfe_buf, 0x1000, env_buf, 0, 0x1000);

            byte[][] env_str = null;
            byte[] lan_mac = null;
            extract_env(ref env_buf, out env_str, out lan_mac);
            string str_mac = Encoding.UTF8.GetString(lan_mac, 0, lan_mac.Length);
            //MessageBox.Show("LAN MAC is " + str_mac);
            textBoxMAC.Text = str_mac;

            //textBox1.Text = "";
            i = 0;
            StringBuilder sb1 = new StringBuilder();
            while (env_str[i][0] != 0) //scan until emty string
            {
                //MessageBox.Show(Encoding .UTF8 .GetString (env_str [i],0,env_str [i].Length));
                sb1.Append(Encoding.UTF8.GetString(env_str[i], 0, null_str_idx(ref env_str[i], 0)) + "\r\n");
                i++;
            }
            string ss = sb1.ToString().Trim();
            textBoxENV.Text = ss;

            //sort_env();

        }

        private void sort_env()
        {
            List<string> lenvs = get_env_list ();
 
            lenvs.Sort();

            textBoxENV.Text = "";
            foreach (string env in lenvs)
            {
                textBoxENV.Text = textBoxENV.Text + env + "\r\n";
            }
            textBoxENV.Text = textBoxENV.Text.Trim();
        }

        static byte[] GetBytes(string str)
        {
            byte[] bytes  = Encoding.ASCII.GetBytes(str);
            return bytes;
        }

        

        private void buttonSave_Click(object sender, EventArgs e)
        {
           

            string MAC = textBoxMAC.Text.Trim ();
            string str_env = textBoxENV.Text.Trim ();
            string[] envs  = Regex.Split(str_env, "\r\n|\r|\n");
            byte[] bMAC = GetBytes(MAC);

            List<string> lenvs = new List<string>();
            int i;
            for (i = 0; i < envs.Length; i++)
            {
                lenvs.Add(envs[i]);
            }
            //lenvs.Sort();
            int start = ENV_OFFSET;
            int end;

            //store new mac
            Array.Copy(bMAC, 0, env_buf, MAC_OFFSET, 17);
            
            //Clear old env string
            byte[] bempty = new byte[ENV_STR_LEN];
            Array.Copy(bempty, 0, env_buf, ENV_OFFSET, ENV_STR_LEN -1);
            
            
            /*
            for (i = 0; i < envs.Length; i++)
            {
                byte[] tmp = GetBytes(envs[i].Trim ());
                end = start + envs[i].Length;
                Array.Copy(tmp, 0, env_buf, start, envs[i].Trim().Length);
                start = end + 1;
            }
             * */
            textBoxENV.Text = "";
            foreach (string env in lenvs)
            {
                byte[] tmp = GetBytes(env.Trim());
                end = start + env.Length;
                Array.Copy(tmp, 0, env_buf, start, env.Trim().Length);
                start = end + 1;
                textBoxENV.Text = textBoxENV.Text + env + "\r\n";
            }
            textBoxENV.Text = textBoxENV.Text.Trim();

            Array.Copy(env_buf, 0, cfe_buf, 0x1000, env_buf.Length);

            File.WriteAllBytes(textBoxCFEOutput.Text, cfe_buf);
            MessageBox.Show("Write file complete.");
            return;
            //MessageBox.Show("Total env to save: " + envs.Length );
            
        }

        static void set_env(ref List<string> lenvs, string str)
        {
            int eq_idx = str.IndexOf ('=');
            string cmd = null;
            string vari = null;
            cmd = str.Remove(eq_idx);
            if (eq_idx < 0) // no var mean delete env
            {
                foreach (string env in lenvs)
                {
                    int teq = env.IndexOf('=');
                    if (env.Remove(teq) == cmd) //find found env
                    {
                        lenvs.Remove(env);
                        return;
                    }
                }
                //not found skip remove
                return;
            }
            
            vari = str.Substring(eq_idx + 1);
            //MessageBox.Show("CMD: " + cmd + " VAR: " + vari);
            int id = 0;
            foreach (string env in lenvs)
            {
                int teq = env.IndexOf('=');
                if (env.Remove(teq) == cmd) //find found env
                {
                    //lenvs.Remove(env);
                    lenvs[id] = str;
                    //lenvs.Add(str);
                    return;
                }
                id++;
            }
            //not found -> new var
            lenvs.Add(str);
        }

        private List<string> get_env_list()
        {
            string str_env = textBoxENV.Text.Trim();
            string[] envs = Regex.Split(str_env, "\r\n|\r|\n");

            List<string> lenvs = new List<string>();
            int i;
            for (i = 0; i < envs.Length; i++)
            {
                lenvs.Add(envs[i]);
            }
            return lenvs;
        }
        private void button64MBRamMod_Click(object sender, EventArgs e)
        {

            List<string> lenvs = get_env_list();

            string[] cmd = new string[3];
            cmd[0] = "sdram_init=0x0113";
            cmd[1] = "sdram_ncdl=0x0";
            cmd[2] = "manual_boot_nv=1";

            set_env(ref lenvs, cmd[0]);
            set_env(ref lenvs, cmd[1]);
            set_env(ref lenvs, cmd[2]);

            //lenvs.Sort();
            textBoxENV.Text = "";
            foreach (string env in lenvs)
            {
                textBoxENV.Text = textBoxENV.Text + env + "\r\n";
            }
            textBoxENV.Text = textBoxENV.Text.Trim();
            MessageBox.Show("64MB RAM Mod has been set.");
        }

       
    }
}

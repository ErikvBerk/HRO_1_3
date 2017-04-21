using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bing_Navigator
{
    
    public partial class Custom_navigation : Form
    {
        string url_standard = "https://www.bing.com/maps?rtp=";
        string text_list_var = "";
        string url_list_var = "";

        List<string> url_list = new List<string> { };
        List<string> locations_list = new List<string> { }; 
        

        int list_counter = 0;

        public Custom_navigation()

        {
            
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

        }

        private void menu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string i in url_list)
            {
                url_list_var += i;

            }

            url_standard = url_list_var;
            url_list_var = "";
            webBrowser1.Url = new System.Uri("https://www.bing.com/maps?rtp=" + url_standard);



            // textbox
            if (textbox_route_list.Visible == false)
            {
                textbox_route_list.Visible = true;
            }
            else if (textbox_route_list.Visible == true)
            {
                textbox_route_list.Visible = false;
            }
            //label 
            if (label_locations.Visible == false)
            {
                label_locations.Visible = true;
            }
            else if (label_locations.Visible == true)
            {
                label_locations.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            list_counter += 1;

            url_list.Add("~adr." + textBox1.Text);

            
            locations_list.Add(list_counter.ToString() + ". " + textBox1.Text + "\r\n");


            foreach (string i in locations_list)
            {
                text_list_var += i;
                
            }
            textbox_route_list.Text = text_list_var;
            

            
            
            
            textBox1.Text = "";
            text_list_var = "";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_list_Click(object sender, EventArgs e)
        {
            list_counter = 0;

            url_standard= "https://www.bing.com/maps?rtp=" ;
            url_list.Clear();

            locations_list.Clear();

            
            textbox_route_list.Text = "";
            

            
        }

        private void button_url_visable_Click(object sender, EventArgs e)
        {
            // webbrowser
            if (webBrowser1.Visible == false)
            {
                webBrowser1.Visible = true;
            }
            else if (webBrowser1.Visible == true )
            {
                webBrowser1.Visible = false;
            }

            // textbox
            if (textbox_route_list.Visible == false)
            {
                textbox_route_list.Visible = true;
            }
            else if (textbox_route_list.Visible==true)
            {
                textbox_route_list.Visible = false;
            }
            //label 
            if (label_locations.Visible==false)
            {
                label_locations.Visible = true;
            }
            else if (label_locations.Visible==true)
            {
                label_locations.Visible = false;
            }
        }

        private void textbox_route_list_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

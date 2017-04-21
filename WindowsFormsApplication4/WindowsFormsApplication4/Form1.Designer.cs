namespace Bing_Navigator
{
    partial class Custom_navigation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Button_run_location = new System.Windows.Forms.Button();
            this.button_location = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_clear_list = new System.Windows.Forms.Button();
            this.button_url_visable = new System.Windows.Forms.Button();
            this.textbox_route_list = new System.Windows.Forms.TextBox();
            this.label_locations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1009, 520);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Button_run_location
            // 
            this.Button_run_location.Location = new System.Drawing.Point(336, 0);
            this.Button_run_location.Name = "Button_run_location";
            this.Button_run_location.Size = new System.Drawing.Size(103, 23);
            this.Button_run_location.TabIndex = 2;
            this.Button_run_location.Text = "Run list";
            this.Button_run_location.UseVisualStyleBackColor = true;
            this.Button_run_location.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_location
            // 
            this.button_location.Location = new System.Drawing.Point(0, 0);
            this.button_location.Name = "button_location";
            this.button_location.Size = new System.Drawing.Size(103, 23);
            this.button_location.TabIndex = 3;
            this.button_location.Text = "Add_location";
            this.button_location.UseVisualStyleBackColor = true;
            this.button_location.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(126, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(91, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_clear_list
            // 
            this.button_clear_list.Location = new System.Drawing.Point(445, 1);
            this.button_clear_list.Name = "button_clear_list";
            this.button_clear_list.Size = new System.Drawing.Size(103, 23);
            this.button_clear_list.TabIndex = 5;
            this.button_clear_list.Text = "clear list";
            this.button_clear_list.UseVisualStyleBackColor = true;
            this.button_clear_list.Click += new System.EventHandler(this.button_clear_list_Click);
            // 
            // button_url_visable
            // 
            this.button_url_visable.Location = new System.Drawing.Point(671, 0);
            this.button_url_visable.Name = "button_url_visable";
            this.button_url_visable.Size = new System.Drawing.Size(111, 23);
            this.button_url_visable.TabIndex = 6;
            this.button_url_visable.Text = "Map_on/off";
            this.button_url_visable.UseVisualStyleBackColor = true;
            this.button_url_visable.Click += new System.EventHandler(this.button_url_visable_Click);
            // 
            // textbox_route_list
            // 
            this.textbox_route_list.Location = new System.Drawing.Point(396, 137);
            this.textbox_route_list.Multiline = true;
            this.textbox_route_list.Name = "textbox_route_list";
            this.textbox_route_list.Size = new System.Drawing.Size(164, 108);
            this.textbox_route_list.TabIndex = 7;
            this.textbox_route_list.TextChanged += new System.EventHandler(this.textbox_route_list_TextChanged);
            // 
            // label_locations
            // 
            this.label_locations.AutoSize = true;
            this.label_locations.Location = new System.Drawing.Point(402, 113);
            this.label_locations.Name = "label_locations";
            this.label_locations.Size = new System.Drawing.Size(69, 17);
            this.label_locations.TabIndex = 8;
            this.label_locations.Text = "Locations";
            // 
            // Custom_navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 520);
            this.Controls.Add(this.label_locations);
            this.Controls.Add(this.textbox_route_list);
            this.Controls.Add(this.button_url_visable);
            this.Controls.Add(this.button_clear_list);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_location);
            this.Controls.Add(this.Button_run_location);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Custom_navigation";
            this.Text = "Custom_navigation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Button_run_location;
        private System.Windows.Forms.Button button_location;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_clear_list;
        private System.Windows.Forms.Button button_url_visable;
        private System.Windows.Forms.TextBox textbox_route_list;
        private System.Windows.Forms.Label label_locations;
    }
}


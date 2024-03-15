namespace Explorer_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbOpen = new TextBox();
            label2 = new Label();
            btOpen = new Button();
            imageList1 = new ImageList(components);
            listView = new ListView();
            SuspendLayout();
            // 
            // tbOpen
            // 
            tbOpen.Location = new Point(79, 454);
            tbOpen.Name = "tbOpen";
            tbOpen.ReadOnly = true;
            tbOpen.Size = new Size(575, 27);
            tbOpen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 457);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 3;
            label2.Text = "Path:";
            // 
            // btOpen
            // 
            btOpen.Location = new Point(676, 453);
            btOpen.Name = "btOpen";
            btOpen.Size = new Size(94, 29);
            btOpen.TabIndex = 4;
            btOpen.Text = "Open";
            btOpen.UseVisualStyleBackColor = true;
            btOpen.Click += btOpen_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(32, 32);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // listView
            // 
            listView.LargeImageList = imageList1;
            listView.Location = new Point(23, 12);
            listView.MultiSelect = false;
            listView.Name = "listView";
            listView.Size = new Size(747, 435);
            listView.TabIndex = 5;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 504);
            Controls.Add(listView);
            Controls.Add(btOpen);
            Controls.Add(label2);
            Controls.Add(tbOpen);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btVao;
        private Button btRa;
        private TextBox tbOpen;
        private Label label2;
        private Button btOpen;
        private ImageList imageList1;
        private ListView listView;
    }
}

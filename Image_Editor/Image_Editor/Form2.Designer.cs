namespace Image_Editor
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            close_button = new Button();
            save_button = new Button();
            clear_button = new Button();
            toolboxpanel = new Panel();
            paintbrush_button = new PictureBox();
            pictureBox1 = new PictureBox();
            paintbrush_size = new NumericUpDown();
            eraser_button = new PictureBox();
            colorbox = new PictureBox();
            TopPanel = new Panel();
            label1 = new Label();
            canvaspanel = new Panel();
            button1 = new Button();
            toolboxpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)paintbrush_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paintbrush_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)eraser_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colorbox).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // close_button
            // 
            close_button.BackColor = Color.PaleVioletRed;
            close_button.FlatStyle = FlatStyle.Flat;
            close_button.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            close_button.ForeColor = SystemColors.ButtonHighlight;
            close_button.Location = new Point(668, 3);
            close_button.Name = "close_button";
            close_button.Size = new Size(36, 23);
            close_button.TabIndex = 0;
            close_button.Text = "X";
            close_button.UseVisualStyleBackColor = false;
            close_button.Click += close_button_Click;
            // 
            // save_button
            // 
            save_button.FlatStyle = FlatStyle.Flat;
            save_button.Font = new Font("Monotype Corsiva", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            save_button.ForeColor = SystemColors.ButtonHighlight;
            save_button.Location = new Point(574, 3);
            save_button.Name = "save_button";
            save_button.Size = new Size(83, 32);
            save_button.TabIndex = 1;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click_1;
            // 
            // clear_button
            // 
            clear_button.FlatStyle = FlatStyle.Flat;
            clear_button.Font = new Font("Monotype Corsiva", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            clear_button.ForeColor = SystemColors.ButtonHighlight;
            clear_button.Location = new Point(485, 3);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(83, 32);
            clear_button.TabIndex = 2;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = true;
            clear_button.Click += clear_button_Click_1;
            // 
            // toolboxpanel
            // 
            toolboxpanel.BackColor = SystemColors.ActiveCaption;
            toolboxpanel.Controls.Add(paintbrush_button);
            toolboxpanel.Controls.Add(pictureBox1);
            toolboxpanel.Controls.Add(paintbrush_size);
            toolboxpanel.Controls.Add(eraser_button);
            toolboxpanel.Controls.Add(colorbox);
            toolboxpanel.Dock = DockStyle.Left;
            toolboxpanel.Location = new Point(0, 0);
            toolboxpanel.Name = "toolboxpanel";
            toolboxpanel.Size = new Size(93, 540);
            toolboxpanel.TabIndex = 3;
            // 
            // paintbrush_button
            // 
            paintbrush_button.Image = (Image)resources.GetObject("paintbrush_button.Image");
            paintbrush_button.Location = new Point(1, 252);
            paintbrush_button.Name = "paintbrush_button";
            paintbrush_button.Size = new Size(93, 71);
            paintbrush_button.SizeMode = PictureBoxSizeMode.StretchImage;
            paintbrush_button.TabIndex = 1;
            paintbrush_button.TabStop = false;
            paintbrush_button.Click += paintbrush_button_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // paintbrush_size
            // 
            paintbrush_size.Location = new Point(2, 329);
            paintbrush_size.Name = "paintbrush_size";
            paintbrush_size.Size = new Size(92, 23);
            paintbrush_size.TabIndex = 3;
            paintbrush_size.ValueChanged += paintbrush_size_ValueChanged;
            // 
            // eraser_button
            // 
            eraser_button.Image = (Image)resources.GetObject("eraser_button.Image");
            eraser_button.Location = new Point(-1, 358);
            eraser_button.Name = "eraser_button";
            eraser_button.Size = new Size(94, 74);
            eraser_button.SizeMode = PictureBoxSizeMode.StretchImage;
            eraser_button.TabIndex = 2;
            eraser_button.TabStop = false;
            eraser_button.Click += eraser_button_Click_1;
            // 
            // colorbox
            // 
            colorbox.Image = (Image)resources.GetObject("colorbox.Image");
            colorbox.Location = new Point(1, 180);
            colorbox.Name = "colorbox";
            colorbox.Size = new Size(92, 66);
            colorbox.SizeMode = PictureBoxSizeMode.StretchImage;
            colorbox.TabIndex = 0;
            colorbox.TabStop = false;
            colorbox.Click += colorbox_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = SystemColors.ActiveCaption;
            TopPanel.Controls.Add(button1);
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(clear_button);
            TopPanel.Controls.Add(close_button);
            TopPanel.Controls.Add(save_button);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(93, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(707, 76);
            TopPanel.TabIndex = 4;
            TopPanel.MouseDown += TopPanel_MouseDown;
            TopPanel.MouseMove += TopPanel_MouseMove;
            TopPanel.MouseUp += TopPanel_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(239, 33);
            label1.TabIndex = 3;
            label1.Text = "Drawing Application";
            // 
            // canvaspanel
            // 
            canvaspanel.BackColor = SystemColors.ButtonHighlight;
            canvaspanel.Dock = DockStyle.Fill;
            canvaspanel.Location = new Point(93, 76);
            canvaspanel.Name = "canvaspanel";
            canvaspanel.Size = new Size(707, 464);
            canvaspanel.TabIndex = 5;
            canvaspanel.MouseDown += canvas_mousedown;
            canvaspanel.MouseMove += canvas_MouseMove;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleVioletRed;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(485, 38);
            button1.Name = "button1";
            button1.Size = new Size(172, 35);
            button1.TabIndex = 4;
            button1.Text = "Image Editor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(canvaspanel);
            Controls.Add(TopPanel);
            Controls.Add(toolboxpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Drawing Application";
            toolboxpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)paintbrush_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)paintbrush_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)eraser_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)colorbox).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button close_button;
        private Button save_button;
        private Button clear_button;
        private Panel toolboxpanel;
        private Panel TopPanel;
        private Panel canvaspanel;
        private PictureBox pictureBox1;
        private NumericUpDown paintbrush_size;
        private PictureBox eraser_button;
        private PictureBox paintbrush_button;
        private PictureBox colorbox;
        private Label label1;
        private Button button1;
    }
}
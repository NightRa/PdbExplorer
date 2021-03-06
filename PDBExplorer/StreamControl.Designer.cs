namespace PDBExplorer
{
    partial class StreamControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resultTextArea = new System.Windows.Forms.TextBox();
            this.saveStreamButton = new System.Windows.Forms.Button();
            this.openStreamButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultTextArea
            // 
            this.resultTextArea.Location = new System.Drawing.Point(0, 0);
            this.resultTextArea.Multiline = true;
            this.resultTextArea.Name = "resultTextArea";
            this.resultTextArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextArea.Size = new System.Drawing.Size(585, 361);
            this.resultTextArea.TabIndex = 4;
            // 
            // saveStreamButton
            // 
            this.saveStreamButton.Location = new System.Drawing.Point(458, 4);
            this.saveStreamButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveStreamButton.Name = "saveStreamButton";
            this.saveStreamButton.Size = new System.Drawing.Size(100, 31);
            this.saveStreamButton.TabIndex = 5;
            this.saveStreamButton.Text = "Save Stream";
            this.saveStreamButton.UseVisualStyleBackColor = true;
            this.saveStreamButton.Click += new System.EventHandler(this.saveStreamButton_Click);
            // 
            // openStreamButton
            // 
            this.openStreamButton.Location = new System.Drawing.Point(352, 4);
            this.openStreamButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.openStreamButton.Name = "openStreamButton";
            this.openStreamButton.Size = new System.Drawing.Size(100, 31);
            this.openStreamButton.TabIndex = 6;
            this.openStreamButton.Text = "Open in 010";
            this.openStreamButton.UseVisualStyleBackColor = true;
            this.openStreamButton.Click += new System.EventHandler(this.openStreamButton_Click);
            // 
            // StreamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.openStreamButton);
            this.Controls.Add(this.saveStreamButton);
            this.Controls.Add(this.resultTextArea);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StreamControl";
            this.Size = new System.Drawing.Size(585, 363);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button saveStreamButton;
        public TextBox resultTextArea;
        private Button openStreamButton;
    }
}

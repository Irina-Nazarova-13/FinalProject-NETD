
namespace Lab5
{
    partial class formTextEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTextEditor));
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.toolTipForTextEditor = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(197)))));
            this.richTextBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.richTextBoxInput.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxInput.Size = new System.Drawing.Size(578, 530);
            this.richTextBoxInput.TabIndex = 1;
            this.richTextBoxInput.TabStop = false;
            this.richTextBoxInput.Text = "";
            this.richTextBoxInput.TextChanged += new System.EventHandler(this.textBoxEdited);
            this.richTextBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBoxInputKeyPress);
            // 
            // formTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(249)))), ((int)(((byte)(155)))));
            this.ClientSize = new System.Drawing.Size(578, 530);
            this.Controls.Add(this.richTextBoxInput);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formTextEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor Select A File To Open";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formTextEditorFormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.ToolTip toolTipForTextEditor;
    }
}


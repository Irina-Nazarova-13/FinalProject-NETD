
namespace CE1
{
    partial class formAwesomeness
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAwesomeness));
            this.buttonYes = new System.Windows.Forms.Button();
            this.buttonNoLeft = new System.Windows.Forms.Button();
            this.buttonNoRight = new System.Windows.Forms.Button();
            this.labelAwesomenessMessage = new System.Windows.Forms.Label();
            this.toolTipAwesomeness = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonYes
            // 
            this.buttonYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(194)))));
            this.buttonYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonYes.Location = new System.Drawing.Point(49, 161);
            this.buttonYes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(117, 66);
            this.buttonYes.TabIndex = 1;
            this.buttonYes.Text = "&Yes";
            this.toolTipAwesomeness.SetToolTip(this.buttonYes, "Click \'Yes\' if you\'re awesome");
            this.buttonYes.UseVisualStyleBackColor = false;
            this.buttonYes.Click += new System.EventHandler(this.buttonYes_Click);
            // 
            // buttonNoLeft
            // 
            this.buttonNoLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(194)))));
            this.buttonNoLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoLeft.Location = new System.Drawing.Point(207, 161);
            this.buttonNoLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNoLeft.Name = "buttonNoLeft";
            this.buttonNoLeft.Size = new System.Drawing.Size(117, 66);
            this.buttonNoLeft.TabIndex = 2;
            this.buttonNoLeft.Text = "&No";
            this.toolTipAwesomeness.SetToolTip(this.buttonNoLeft, "Click \'No\' if you are not awesome");
            this.buttonNoLeft.UseVisualStyleBackColor = false;
            this.buttonNoLeft.Click += new System.EventHandler(this.buttonNoLeft_Click);
            this.buttonNoLeft.MouseEnter += new System.EventHandler(this.buttonNoLeft_Click);
            // 
            // buttonNoRight
            // 
            this.buttonNoRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(252)))), ((int)(((byte)(194)))));
            this.buttonNoRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNoRight.Location = new System.Drawing.Point(380, 161);
            this.buttonNoRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNoRight.Name = "buttonNoRight";
            this.buttonNoRight.Size = new System.Drawing.Size(121, 66);
            this.buttonNoRight.TabIndex = 3;
            this.buttonNoRight.Text = "&No";
            this.toolTipAwesomeness.SetToolTip(this.buttonNoRight, "Click \'No\' if you are not awesome");
            this.buttonNoRight.UseVisualStyleBackColor = false;
            this.buttonNoRight.Visible = false;
            this.buttonNoRight.Click += new System.EventHandler(this.buttonNoRight_Click);
            this.buttonNoRight.MouseEnter += new System.EventHandler(this.buttonNoRight_Click);
            // 
            // labelAwesomenessMessage
            // 
            this.labelAwesomenessMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelAwesomenessMessage.Location = new System.Drawing.Point(69, 35);
            this.labelAwesomenessMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAwesomenessMessage.Name = "labelAwesomenessMessage";
            this.labelAwesomenessMessage.Size = new System.Drawing.Size(397, 98);
            this.labelAwesomenessMessage.TabIndex = 0;
            this.labelAwesomenessMessage.Text = "The computer detected that you are awesome!\r\nIs it possible that you are awesome?" +
    "\r\n";
            this.labelAwesomenessMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formAwesomeness
            // 
            this.AcceptButton = this.buttonYes;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(252)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(541, 279);
            this.Controls.Add(this.labelAwesomenessMessage);
            this.Controls.Add(this.buttonNoRight);
            this.Controls.Add(this.buttonNoLeft);
            this.Controls.Add(this.buttonYes);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAwesomeness";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Awesomeness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.Button buttonNoLeft;
        private System.Windows.Forms.Button buttonNoRight;
        private System.Windows.Forms.Label labelAwesomenessMessage;
        private System.Windows.Forms.ToolTip toolTipAwesomeness;
    }
}


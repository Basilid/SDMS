namespace SupremeDiscordMessage.Forms
{
    partial class frmStringQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStringQuery));
            this.tbString = new System.Windows.Forms.CueTextBox();
            this.ilButtons = new System.Windows.Forms.ImageList(this.components);
            this.bCancel = new System.Windows.Forms.Button();
            this.bApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbString
            // 
            this.tbString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbString.Cue = "Введите новое название";
            this.tbString.Location = new System.Drawing.Point(14, 13);
            this.tbString.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbString.Name = "tbString";
            this.tbString.Size = new System.Drawing.Size(318, 27);
            this.tbString.TabIndex = 1;
            // 
            // ilButtons
            // 
            this.ilButtons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilButtons.ImageStream")));
            this.ilButtons.TransparentColor = System.Drawing.Color.Transparent;
            this.ilButtons.Images.SetKeyName(0, "apply.png");
            this.ilButtons.Images.SetKeyName(1, "cancel.png");
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.bCancel.ImageKey = "cancel.png";
            this.bCancel.ImageList = this.ilButtons;
            this.bCancel.Location = new System.Drawing.Point(131, 48);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(28, 28);
            this.bCancel.TabIndex = 3;
            this.bCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bCancel.UseVisualStyleBackColor = false;
            // 
            // bApply
            // 
            this.bApply.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApply.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bApply.ForeColor = System.Drawing.Color.DarkGreen;
            this.bApply.ImageKey = "apply.png";
            this.bApply.ImageList = this.ilButtons;
            this.bApply.Location = new System.Drawing.Point(14, 48);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(111, 28);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Принять";
            this.bApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bApply.UseVisualStyleBackColor = false;
            // 
            // frmStringQuery
            // 
            this.AcceptButton = this.bApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(346, 88);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.tbString);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmStringQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введите строку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CueTextBox tbString;
        private System.Windows.Forms.ImageList ilButtons;
        public System.Windows.Forms.Button bApply;
        public System.Windows.Forms.Button bCancel;
    }
}
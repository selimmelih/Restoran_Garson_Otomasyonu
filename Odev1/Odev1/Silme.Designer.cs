namespace Odev1
{
    partial class Silme
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
            this.BtnHayir = new System.Windows.Forms.Button();
            this.BtnEvet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHayir
            // 
            this.BtnHayir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnHayir.Location = new System.Drawing.Point(224, 126);
            this.BtnHayir.Name = "BtnHayir";
            this.BtnHayir.Size = new System.Drawing.Size(112, 37);
            this.BtnHayir.TabIndex = 7;
            this.BtnHayir.Text = "HAYIR";
            this.BtnHayir.UseVisualStyleBackColor = true;
            this.BtnHayir.Click += new System.EventHandler(this.BtnHayir_Click);
            // 
            // BtnEvet
            // 
            this.BtnEvet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEvet.Location = new System.Drawing.Point(56, 126);
            this.BtnEvet.Name = "BtnEvet";
            this.BtnEvet.Size = new System.Drawing.Size(118, 37);
            this.BtnEvet.TabIndex = 6;
            this.BtnEvet.Text = "EVET";
            this.BtnEvet.UseVisualStyleBackColor = true;
            this.BtnEvet.Click += new System.EventHandler(this.BtnEvet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(37, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(142, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "No\'lu siparişi silmeye emin misin?";
            // 
            // Silme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(454, 241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHayir);
            this.Controls.Add(this.BtnEvet);
            this.Name = "Silme";
            this.Text = "Sipariş Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button BtnHayir;
        public System.Windows.Forms.Button BtnEvet;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
    }
}
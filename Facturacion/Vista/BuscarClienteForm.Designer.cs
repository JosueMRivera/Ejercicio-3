
namespace Vista
{
    partial class BuscarClienteForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombretxt = new System.Windows.Forms.TextBox();
            this.cancelarbt = new System.Windows.Forms.Button();
            this.aceptarbt = new System.Windows.Forms.Button();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Nombretxt
            // 
            this.Nombretxt.Location = new System.Drawing.Point(96, 17);
            this.Nombretxt.Name = "Nombretxt";
            this.Nombretxt.Size = new System.Drawing.Size(478, 22);
            this.Nombretxt.TabIndex = 1;
            this.Nombretxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Nombretxt_KeyUp);
            // 
            // cancelarbt
            // 
            this.cancelarbt.Location = new System.Drawing.Point(469, 45);
            this.cancelarbt.Name = "cancelarbt";
            this.cancelarbt.Size = new System.Drawing.Size(105, 40);
            this.cancelarbt.TabIndex = 2;
            this.cancelarbt.Text = "Cancelar";
            this.cancelarbt.UseVisualStyleBackColor = true;
            this.cancelarbt.Click += new System.EventHandler(this.cancelarbt_Click);
            // 
            // aceptarbt
            // 
            this.aceptarbt.Location = new System.Drawing.Point(358, 45);
            this.aceptarbt.Name = "aceptarbt";
            this.aceptarbt.Size = new System.Drawing.Size(105, 40);
            this.aceptarbt.TabIndex = 3;
            this.aceptarbt.Text = "Aceptar";
            this.aceptarbt.UseVisualStyleBackColor = true;
            this.aceptarbt.Click += new System.EventHandler(this.aceptarbt_Click);
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ClientesDGV.Location = new System.Drawing.Point(0, 111);
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.Size = new System.Drawing.Size(607, 189);
            this.ClientesDGV.TabIndex = 4;
            // 
            // BuscarClienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 300);
            this.Controls.Add(this.ClientesDGV);
            this.Controls.Add(this.aceptarbt);
            this.Controls.Add(this.cancelarbt);
            this.Controls.Add(this.Nombretxt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarClienteForm";
            this.Text = "BuscarClienteForm";
            this.Load += new System.EventHandler(this.BuscarClienteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombretxt;
        private System.Windows.Forms.Button cancelarbt;
        private System.Windows.Forms.Button aceptarbt;
        private System.Windows.Forms.DataGridView ClientesDGV;
    }
}
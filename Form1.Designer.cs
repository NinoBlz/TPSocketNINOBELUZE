using System.Diagnostics;
using System.Net;
using System.Net.Sockets;

namespace TPSocket.Properties
{
    partial class Communication
    {
        private Socket SSocketUDP;

        private EndPoint Destination, Reception;

        private Stopwatch Timer = new Stopwatch();

        private bool MessageRecu;
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
            this.Cree = new System.Windows.Forms.Button();
            this.Ferme = new System.Windows.Forms.Button();
            this.Envoye = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Recevoir = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IPReception = new System.Windows.Forms.TextBox();
            this.IPDestination = new System.Windows.Forms.TextBox();
            this.PortRCP = new System.Windows.Forms.TextBox();
            this.PortDestinataire = new System.Windows.Forms.TextBox();
            this.MessageSaisit = new System.Windows.Forms.TextBox();
            this.MessageR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cree
            // 
            this.Cree.Location = new System.Drawing.Point(305, 17);
            this.Cree.Name = "Cree";
            this.Cree.Size = new System.Drawing.Size(222, 23);
            this.Cree.TabIndex = 0;
            this.Cree.Text = "Créer socket et Bind(IPepR)";
            this.Cree.UseVisualStyleBackColor = true;
            this.Cree.Click += new System.EventHandler(this.Cree_Click);
            // 
            // Ferme
            // 
            this.Ferme.Location = new System.Drawing.Point(305, 46);
            this.Ferme.Name = "Ferme";
            this.Ferme.Size = new System.Drawing.Size(224, 23);
            this.Ferme.TabIndex = 1;
            this.Ferme.Text = "Fermer : close()";
            this.Ferme.UseVisualStyleBackColor = true;
            this.Ferme.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // Envoye
            // 
            this.Envoye.Location = new System.Drawing.Point(326, 108);
            this.Envoye.Name = "Envoye";
            this.Envoye.Size = new System.Drawing.Size(203, 45);
            this.Envoye.TabIndex = 2;
            this.Envoye.Text = "Envoyer : SendTo(ipedD)";
            this.Envoye.UseVisualStyleBackColor = true;
            this.Envoye.Click += new System.EventHandler(this.Envoye_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 199);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 48);
            this.button4.TabIndex = 3;
            this.button4.Text = " Reception : Receivve() bloquant+timeout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(341, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Reception + timer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Recevoir
            // 
            this.Recevoir.Location = new System.Drawing.Point(341, 313);
            this.Recevoir.Name = "Recevoir";
            this.Recevoir.Size = new System.Drawing.Size(188, 31);
            this.Recevoir.TabIndex = 5;
            this.Recevoir.Text = "Reception + thread";
            this.Recevoir.UseVisualStyleBackColor = true;
            this.Recevoir.Click += new System.EventHandler(this.Reception_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(341, 359);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(186, 39);
            this.button7.TabIndex = 6;
            this.button7.Text = "CLS";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Recp.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Dest";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ipedR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ipedD";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // IPReception
            // 
            this.IPReception.Location = new System.Drawing.Point(48, 19);
            this.IPReception.Name = "IPReception";
            this.IPReception.Size = new System.Drawing.Size(106, 20);
            this.IPReception.TabIndex = 11;
            this.IPReception.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IPDestination
            // 
            this.IPDestination.Location = new System.Drawing.Point(48, 50);
            this.IPDestination.Name = "IPDestination";
            this.IPDestination.Size = new System.Drawing.Size(106, 20);
            this.IPDestination.TabIndex = 12;
            this.IPDestination.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PortRCP
            // 
            this.PortRCP.Location = new System.Drawing.Point(172, 19);
            this.PortRCP.Name = "PortRCP";
            this.PortRCP.Size = new System.Drawing.Size(54, 20);
            this.PortRCP.TabIndex = 13;
            this.PortRCP.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PortDestinataire
            // 
            this.PortDestinataire.Location = new System.Drawing.Point(173, 49);
            this.PortDestinataire.Name = "PortDestinataire";
            this.PortDestinataire.Size = new System.Drawing.Size(53, 20);
            this.PortDestinataire.TabIndex = 14;
            this.PortDestinataire.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // MessageSaisit
            // 
            this.MessageSaisit.Location = new System.Drawing.Point(12, 108);
            this.MessageSaisit.Multiline = true;
            this.MessageSaisit.Name = "MessageSaisit";
            this.MessageSaisit.Size = new System.Drawing.Size(308, 62);
            this.MessageSaisit.TabIndex = 15;
            this.MessageSaisit.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // MessageR
            // 
            this.MessageR.Location = new System.Drawing.Point(12, 199);
            this.MessageR.Multiline = true;
            this.MessageR.Name = "MessageR";
            this.MessageR.Size = new System.Drawing.Size(308, 199);
            this.MessageR.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // Communication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MessageR);
            this.Controls.Add(this.MessageSaisit);
            this.Controls.Add(this.PortDestinataire);
            this.Controls.Add(this.PortRCP);
            this.Controls.Add(this.IPDestination);
            this.Controls.Add(this.IPReception);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Recevoir);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Envoye);
            this.Controls.Add(this.Ferme);
            this.Controls.Add(this.Cree);
            this.Name = "Communication";
            this.Text = "Communication par Socket UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cree;
        private System.Windows.Forms.Button Ferme;
        private System.Windows.Forms.Button Envoye;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Recevoir;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IPReception;
        private System.Windows.Forms.TextBox IPDestination;
        private System.Windows.Forms.TextBox PortRCP;
        private System.Windows.Forms.TextBox PortDestinataire;
        private System.Windows.Forms.TextBox MessageSaisit;
        private System.Windows.Forms.TextBox MessageR;
        private System.Windows.Forms.Label label5;
    }
}
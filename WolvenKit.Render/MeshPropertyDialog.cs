using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Render
{
    public partial class MeshPropertyDialog : Form
    {
        public MeshPropertyDialog()
        {
            InitializeComponent();
            modifications = new HashSet<SceneNode>();
        }

        private SceneNode Node;
        private Vector3Df Translation;
        private Vector3Df Rotation;
        private HashSet<SceneNode> modifications;

        public HashSet<SceneNode> GetModifiedNodes()
        {
            return modifications;
        }

        public void SetProperties(SceneNode node)
        {
            ResetBtn.Enabled = false;

            Node = node;

            xTranslationTextBox.Text = Node.Position.X.ToString();
            yTranslationTextBox.Text = Node.Position.Y.ToString();
            zTranslationTextBox.Text = Node.Position.Z.ToString();

            xRotationTextBox.Text = Node.Rotation.X.ToString();
            yRotationTextBox.Text = Node.Rotation.Y.ToString();
            zRotationTextBox.Text = Node.Rotation.Z.ToString();

            Translation = new Vector3Df(node.Position);
            Rotation = new Vector3Df(node.Rotation);
        }

        public void SetName(string name)
        {
            Text = name;
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            bool modified = false;

            // update the node!
            if (float.TryParse(xTranslationTextBox.Text, out float tx))
            {
                if (float.TryParse(yTranslationTextBox.Text, out float ty))
                {
                    if (float.TryParse(zTranslationTextBox.Text, out float tz))
                    {
                        Node.Position = new Vector3Df(tx, ty, tz);
                        modified = true;
                    }
                }
            }

            if (float.TryParse(xRotationTextBox.Text, out float rx))
            {
                if (float.TryParse(yRotationTextBox.Text, out float ry))
                {
                    if (float.TryParse(zRotationTextBox.Text, out float rz))
                    {
                        Node.Rotation = new Vector3Df(rx, ry, rz);
                        modified = true;
                    }
                }
            }

            ResetBtn.Enabled = modified;

            if (!modifications.Contains(Node))
            {
                // not in the set, so add it
                modifications.Add(Node);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Node.Position = Translation;
            Node.Rotation = Rotation;

            xTranslationTextBox.Text = Node.Position.X.ToString();
            yTranslationTextBox.Text = Node.Position.Y.ToString();
            zTranslationTextBox.Text = Node.Position.Z.ToString();

            xRotationTextBox.Text = Node.Rotation.X.ToString();
            yRotationTextBox.Text = Node.Rotation.Y.ToString();
            zRotationTextBox.Text = Node.Rotation.Z.ToString();

            modifications.Remove(Node);
        }
    }
}

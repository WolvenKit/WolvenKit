using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System.Windows.Forms;

namespace WolvenKit.Render
{
    public class RenderTreeNode : TreeNode
    {
        public RenderTreeNode(string text, int id, Mesh m, Vector3Df pos, Vector3Df rot) : base(text)
        {
            Mesh = m;

            ID = id;
            Position = pos;
            Rotation = rot;

            MeshNode = null;
        }

        public Mesh Mesh { get; set; }

        public int ID { get; set; }
        public Vector3Df Position { get; set; }
        public Vector3Df Rotation { get; set; }
        public SceneNode MeshNode { get; set; }
    }
}

using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System.Windows.Forms;

namespace WolvenKit.Render
{
    public class RenderTreeNode : TreeNode
    {
        public RenderTreeNode(string text, SceneNode n) : base(text)
        {
            MeshNode = n;
        }

        public SceneNode MeshNode { get; set; }
    }
}

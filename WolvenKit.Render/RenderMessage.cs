using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WolvenKit.Render
{
    public enum MessageType
    {
        INVALID = 0,
        ADD_MESH_NODE,
        ADD_TERRAIN_NODE,
        SHOW_NODE,
        HIDE_NODE,
        SELECT_NODE,
        DESELECT_NODE,
        SHUTDOWN,
        NUM_MESSAGE_TYPES
    };

    public class RenderMessage
    {
        public RenderMessage(MessageType m, string name, Vector3Df translation, Vector3Df rotation, TreeNode tn)
        {
            Message = m;
            MeshName = name;
            TreeNode = tn;
            Translation = translation;
            Rotation = rotation;

            Node = null;
            MaxHeight = 0.0f;
            MinHeight = 0.0f;
            TileRes = 0;
            TerrainSize = 0.0f;
        }

        public RenderMessage(MessageType m, string name, uint tileRes, float maxHeight, float minHeight, float terrainSize, Vector3Df anchorPt, TreeNode tn)
        {
            Message = m;
            MeshName = name;
            TreeNode = tn;
            Translation = anchorPt;
            MaxHeight = maxHeight;
            MinHeight = minHeight;
            TileRes = tileRes;
            TerrainSize = terrainSize;

            Node = null;
            Rotation = new Vector3Df(0.0f, 0.0f, 0.0f);
        }

        public RenderMessage(MessageType m, SceneNode n)
        {
            Message = m;
            Node = n;

            MeshName = "";
            TreeNode = null;
            Rotation = new Vector3Df(0.0f, 0.0f, 0.0f);
            Translation = new Vector3Df(0.0f, 0.0f, 0.0f);
            MaxHeight = 0.0f;
            MinHeight = 0.0f;
            TileRes = 0;
            TerrainSize = 0.0f;
        }

        public RenderMessage(MessageType m)
        {
            Message = m;
            
            Node = null;
            MeshName = "";
            TreeNode = null;
            Rotation = new Vector3Df(0.0f, 0.0f, 0.0f);
            Translation = new Vector3Df(0.0f, 0.0f, 0.0f);
            MaxHeight = 0.0f;
            MinHeight = 0.0f;
            TileRes = 0;
            TerrainSize = 0.0f;
        }

        public string MeshName { get; }
        public Vector3Df Rotation { get; }
        public Vector3Df Translation { get; }
        public MessageType Message { get; }
        public TreeNode TreeNode { get; }
        public SceneNode Node { get; }
        public float MaxHeight { get; }
        public float MinHeight { get; }
        public uint TileRes { get; }
        public float TerrainSize { get; }
    }

}

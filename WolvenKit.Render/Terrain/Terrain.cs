using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IrrlichtLime;

namespace WolvenKit.Render.Terrain
{
    public class Terrain
    {
        private IrrlichtLime.Scene.TriangleSelector _selector;


        public Terrain() { }

        public IrrlichtLime.Scene.TerrainSceneNode LoadTerrain(IrrlichtDevice device, string heightmap, string texture)
        {
            IrrlichtLime.Scene.TerrainSceneNode _terrain;
            _terrain = device.SceneManager.AddTerrainSceneNode(heightmap, 
                                null,                                               // parent node
                                -1,                                                 // node id
                                new IrrlichtLime.Core.Vector3Df(0.0f, 0.0f, 0.0f),  // position
                                new IrrlichtLime.Core.Vector3Df(0.0f, 0.0f, 0.0f),  // rotation
                                new IrrlichtLime.Core.Vector3Df(40.0f, 4.4f, 40.0f),// scale
                                new IrrlichtLime.Video.Color(255, 255, 255, 255),   // vertexColor
                                5,                                                  // maxLOD
                                IrrlichtLime.Scene.TerrainPatchSize._17,            // patchSize
                                4);                                                 // smoothFactor
            _terrain.Scale = new IrrlichtLime.Core.Vector3Df(32, 5, 32);
            _terrain.SetMaterialFlag(IrrlichtLime.Video.MaterialFlag.Lighting, false);

            var text = device.VideoDriver.GetTexture(texture);


            _terrain.SetMaterialTexture(0, text);

            _terrain.Position = new IrrlichtLime.Core.Vector3Df(0.0f);
            
            return _terrain;
            
        }


    }
}

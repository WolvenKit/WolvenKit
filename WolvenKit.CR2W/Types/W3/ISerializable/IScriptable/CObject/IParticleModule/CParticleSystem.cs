
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
	class CParticleSystem : CVector
    {
        public CArray lods;
		public CArray emitters;
		public CFloat autoHideDistance;
		public CFloat autoHideRange;
		public CColor previewBackgroundColor;
		public CBool previewShowGrid;
		public CBool visibleThroughWalls;
		public CFloat prewarmingTime;
		public CName renderingPlane;
		

        public CParticleSystem(CR2WFile cr2w) : base(cr2w)
        {
                lods = new CArray("array:0,0,SParticleSystemLODLevel","SParticleSystemLODLevel", true, cr2w){ Name = "lods", Type = "CArray"};
				emitters = new CArray("array:0,0,ptr:CParticleEmitter","CParticleEmitter", true, cr2w){ Name = "emitters", Type = "CArray"};
				autoHideDistance = new CFloat(cr2w){ Name = "autoHideDistance", Type = "Float"};
				autoHideRange = new CFloat(cr2w){ Name = "autoHideRange", Type = "Float"};
				previewBackgroundColor = new CColor(cr2w){ Name = "previewBackgroundColor", Type = "Color"};
				previewShowGrid = new CBool(cr2w){ Name = "previewShowGrid", Type = "Bool"};
				visibleThroughWalls = new CBool(cr2w){ Name = "visibleThroughWalls", Type = "Bool"};
				prewarmingTime = new CFloat(cr2w){ Name = "prewarmingTime", Type = "Float"};
				renderingPlane = new CName(cr2w){ Name = "renderingPlane", Type = "CName"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
                lods.Read(file,size);
				emitters.Read(file,size);
				autoHideDistance.Read(file,size);
				autoHideRange.Read(file,size);
				previewBackgroundColor.Read(file,size);
				previewShowGrid.Read(file,size);
				visibleThroughWalls.Read(file,size);
				prewarmingTime.Read(file,size);
				renderingPlane.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
                lods.Write(file);
				emitters.Write(file);
				autoHideDistance.Write(file);
				autoHideRange.Write(file);
				previewBackgroundColor.Write(file);
				previewShowGrid.Write(file);
				visibleThroughWalls.Write(file);
				prewarmingTime.Write(file);
				renderingPlane.Write(file);
				
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleSystem(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (CParticleSystem)base.Copy(context);
            
                var.lods = (CArray)lods.Copy(context);
				var.emitters = (CArray)emitters.Copy(context);
				var.autoHideDistance = (CFloat)autoHideDistance.Copy(context);
				var.autoHideRange = (CFloat)autoHideRange.Copy(context);
				var.previewBackgroundColor = (CColor)previewBackgroundColor.Copy(context);
				var.previewShowGrid = (CBool)previewShowGrid.Copy(context);
				var.visibleThroughWalls = (CBool)visibleThroughWalls.Copy(context);
				var.prewarmingTime = (CFloat)prewarmingTime.Copy(context);
				var.renderingPlane = (CName)renderingPlane.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                lods,
				emitters,
				autoHideDistance,
				autoHideRange,
				previewBackgroundColor,
				previewShowGrid,
				visibleThroughWalls,
				prewarmingTime,
				renderingPlane, 
            };
            return list;
        }
    }
}

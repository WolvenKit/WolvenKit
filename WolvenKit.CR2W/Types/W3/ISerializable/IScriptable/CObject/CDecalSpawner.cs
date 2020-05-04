
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
	class CDecalSpawner : CVector
    {
        public SDynamicDecalMaterialInfo material;
		public CFloat farZ;
		public CFloat nearZ;
		public CPtr ssize;
		public CFloat depthFadePower;
		public CFloat normalFadeBias;
		public CFloat normalFadeScale;
		public CBool doubleSided;
		public CName projectionMode;
		public CPtr decalLifetime;
		public CFloat decalFadeTime;
		public CFloat decalFadeInTime;
		public CBool projectOnlyOnStatic;
		public CFloat startScale;
		public CFloat scaleTime;
		public CBool useVerticalProjection;
		public CName spawnPriority;
		public CFloat autoHideDistance;
		public CFloat spawnFrequency;
		

        public CDecalSpawner(CR2WFile cr2w) : base(cr2w)
        {
                material = new SDynamicDecalMaterialInfo(cr2w){ Name = "material", Type = "SDynamicDecalMaterialInfo"};
				farZ = new CFloat(cr2w){ Name = "farZ", Type = "Float"};
				nearZ = new CFloat(cr2w){ Name = "nearZ", Type = "Float"};
                ssize = new CPtr(cr2w){ Name = "size", Type = "IEvaluatorFloat"};
				depthFadePower = new CFloat(cr2w){ Name = "depthFadePower", Type = "Float"};
				normalFadeBias = new CFloat(cr2w){ Name = "normalFadeBias", Type = "Float"};
				normalFadeScale = new CFloat(cr2w){ Name = "normalFadeScale", Type = "Float"};
				doubleSided = new CBool(cr2w){ Name = "doubleSided", Type = "Bool"};
				projectionMode = new CName(cr2w){ Name = "projectionMode", Type = "CName"};
				decalLifetime = new CPtr(cr2w){ Name = "decalLifetime", Type = "IEvaluatorFloat"};
				decalFadeTime = new CFloat(cr2w){ Name = "decalFadeTime", Type = "Float"};
				decalFadeInTime = new CFloat(cr2w){ Name = "decalFadeInTime", Type = "Float"};
				projectOnlyOnStatic = new CBool(cr2w){ Name = "projectOnlyOnStatic", Type = "Bool"};
				startScale = new CFloat(cr2w){ Name = "startScale", Type = "Float"};
				scaleTime = new CFloat(cr2w){ Name = "scaleTime", Type = "Float"};
				useVerticalProjection = new CBool(cr2w){ Name = "useVerticalProjection", Type = "Bool"};
				spawnPriority = new CName(cr2w){ Name = "spawnPriority", Type = "CName"};
				autoHideDistance = new CFloat(cr2w){ Name = "autoHideDistance", Type = "Float"};
				spawnFrequency = new CFloat(cr2w){ Name = "spawnFrequency", Type = "Float"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
                material.Read(file,size);
				farZ.Read(file,size);
				nearZ.Read(file,size);
                ssize.Read(file, size);
				depthFadePower.Read(file,size);
				normalFadeBias.Read(file,size);
				normalFadeScale.Read(file,size);
				doubleSided.Read(file,size);
				projectionMode.Read(file,size);
				decalLifetime.Read(file,size);
				decalFadeTime.Read(file,size);
				decalFadeInTime.Read(file,size);
				projectOnlyOnStatic.Read(file,size);
				startScale.Read(file,size);
				scaleTime.Read(file,size);
				useVerticalProjection.Read(file,size);
				spawnPriority.Read(file,size);
				autoHideDistance.Read(file,size);
				spawnFrequency.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
                material.Write(file);
				farZ.Write(file);
				nearZ.Write(file);
                ssize.Write(file);
				depthFadePower.Write(file);
				normalFadeBias.Write(file);
				normalFadeScale.Write(file);
				doubleSided.Write(file);
				projectionMode.Write(file);
				decalLifetime.Write(file);
				decalFadeTime.Write(file);
				decalFadeInTime.Write(file);
				projectOnlyOnStatic.Write(file);
				startScale.Write(file);
				scaleTime.Write(file);
				useVerticalProjection.Write(file);
				spawnPriority.Write(file);
				autoHideDistance.Write(file);
				spawnFrequency.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CDecalSpawner(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (CDecalSpawner)base.Copy(context);
            
                var.material = (SDynamicDecalMaterialInfo)material.Copy(context);
				var.farZ = (CFloat)farZ.Copy(context);
				var.nearZ = (CFloat)nearZ.Copy(context);
				var.ssize = (CPtr)ssize.Copy(context);
				var.depthFadePower = (CFloat)depthFadePower.Copy(context);
				var.normalFadeBias = (CFloat)normalFadeBias.Copy(context);
				var.normalFadeScale = (CFloat)normalFadeScale.Copy(context);
				var.doubleSided = (CBool)doubleSided.Copy(context);
				var.projectionMode = (CName)projectionMode.Copy(context);
				var.decalLifetime = (CPtr)decalLifetime.Copy(context);
				var.decalFadeTime = (CFloat)decalFadeTime.Copy(context);
				var.decalFadeInTime = (CFloat)decalFadeInTime.Copy(context);
				var.projectOnlyOnStatic = (CBool)projectOnlyOnStatic.Copy(context);
				var.startScale = (CFloat)startScale.Copy(context);
				var.scaleTime = (CFloat)scaleTime.Copy(context);
				var.useVerticalProjection = (CBool)useVerticalProjection.Copy(context);
				var.spawnPriority = (CName)spawnPriority.Copy(context);
				var.autoHideDistance = (CFloat)autoHideDistance.Copy(context);
				var.spawnFrequency = (CFloat)spawnFrequency.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                material,
				farZ,
				nearZ,
                ssize,
				depthFadePower,
				normalFadeBias,
				normalFadeScale,
				doubleSided,
				projectionMode,
				decalLifetime,
				decalFadeTime,
				decalFadeInTime,
				projectOnlyOnStatic,
				startScale,
				scaleTime,
				useVerticalProjection,
				spawnPriority,
				autoHideDistance,
				spawnFrequency, 
            };
            return list;
        }
    }
}

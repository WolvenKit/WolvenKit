
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
	class SDynamicDecalMaterialInfo : CVector
    {
        public CHandle diffuseTexture;
		public CHandle normalTexture;
		public CColor specularColor;
		public CFloat specularScale;
		public CFloat specularBase;
		public CFloat specularity;
		public CBool additiveNormals;
		public CColor diffuseRandomColor0;
		public CColor diffuseRandomColor1;
		public CName subUVType;
		

        public SDynamicDecalMaterialInfo(CR2WFile cr2w) : base(cr2w)
        {
                diffuseTexture = new CHandle(cr2w){ Name = "diffuseTexture", Type = "CHandle"};
				normalTexture = new CHandle(cr2w){ Name = "normalTexture", Type = "CHandle"};
				specularColor = new CColor(cr2w){ Name = "specularColor", Type = "Color"};
				specularScale = new CFloat(cr2w){ Name = "specularScale", Type = "Float"};
				specularBase = new CFloat(cr2w){ Name = "specularBase", Type = "Float"};
				specularity = new CFloat(cr2w){ Name = "specularity", Type = "Float"};
				additiveNormals = new CBool(cr2w){ Name = "additiveNormals", Type = "Bool"};
				diffuseRandomColor0 = new CColor(cr2w){ Name = "diffuseRandomColor0", Type = "Color"};
				diffuseRandomColor1 = new CColor(cr2w){ Name = "diffuseRandomColor1", Type = "Color"};
				subUVType = new CName(cr2w){ Name = "subUVType", Type = "CName"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
            diffuseTexture.Read(file,size);
			normalTexture.Read(file,size);
            specularColor.Read(file,size); //BUG: fx\monsters\endriaga\spawn_ground\endriaga_spawn_ground.w2p
            //file.BaseStream.Seek(4, SeekOrigin.Current);
            specularScale.Read(file,size);
			specularBase.Read(file,size);
			specularity.Read(file,size);
			additiveNormals.Read(file,size);
			diffuseRandomColor0.Read(file,size);
			diffuseRandomColor1.Read(file,size);
			subUVType.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
            diffuseTexture.Write(file);
			normalTexture.Write(file);
            specularColor.Write(file);
            //file.Write(new byte[] { 0, 0, 0, 0 });
            specularScale.Write(file);
			specularBase.Write(file);
			specularity.Write(file);
			additiveNormals.Write(file);
			diffuseRandomColor0.Write(file);
			diffuseRandomColor1.Write(file);
			subUVType.Write(file);				
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SDynamicDecalMaterialInfo(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (SDynamicDecalMaterialInfo)base.Copy(context);
            
                var.diffuseTexture = (CHandle)diffuseTexture.Copy(context);
				var.normalTexture = (CHandle)normalTexture.Copy(context);
				var.specularColor = (CColor)specularColor.Copy(context);
				var.specularScale = (CFloat)specularScale.Copy(context);
				var.specularBase = (CFloat)specularBase.Copy(context);
				var.specularity = (CFloat)specularity.Copy(context);
				var.additiveNormals = (CBool)additiveNormals.Copy(context);
				var.diffuseRandomColor0 = (CColor)diffuseRandomColor0.Copy(context);
				var.diffuseRandomColor1 = (CColor)diffuseRandomColor1.Copy(context);
				var.subUVType = (CName)subUVType.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                diffuseTexture,
				normalTexture,
				specularColor,
				specularScale,
				specularBase,
				specularity,
				additiveNormals,
				diffuseRandomColor0,
				diffuseRandomColor1,
				subUVType, 
            };
            return list;
        }
    }
}

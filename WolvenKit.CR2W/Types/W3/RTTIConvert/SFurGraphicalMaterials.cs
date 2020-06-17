using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SFurGraphicalMaterials : CVariable
	{
		[RED("color")] 		public SFurColor Color { get; set;}

		[RED("diffuse")] 		public SFurDiffuse Diffuse { get; set;}

		[RED("specular")] 		public SFurSpecular Specular { get; set;}

		[RED("glint")] 		public SFurGlint Glint { get; set;}

		[RED("shadow")] 		public SFurShadow Shadow { get; set;}

		public SFurGraphicalMaterials(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SFurGraphicalMaterials(cr2w);

	}
}
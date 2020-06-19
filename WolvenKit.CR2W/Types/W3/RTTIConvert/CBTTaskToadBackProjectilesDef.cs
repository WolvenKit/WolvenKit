using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskToadBackProjectilesDef : CBTTaskProjectileAttackWithPrepareDef
	{
		[RED("minDistFromTarget")] 		public CFloat MinDistFromTarget { get; set;}

		[RED("maxDistFromTarget")] 		public CFloat MaxDistFromTarget { get; set;}

		[RED("range")] 		public CFloat Range { get; set;}

		[RED("animEvent", 2,0)] 		public CArray<CName> AnimEvent { get; set;}

		[RED("boneNames", 2,0)] 		public CArray<CName> BoneNames { get; set;}

		public CBTTaskToadBackProjectilesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskToadBackProjectilesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
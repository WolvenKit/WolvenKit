using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimAnimsetsParam : CEntityTemplateParam
	{
		[RED("name")] 		public CString Name { get; set;}

		[RED("componentName")] 		public CString ComponentName { get; set;}

		[RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		public CAnimAnimsetsParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAnimAnimsetsParam(cr2w);

	}
}
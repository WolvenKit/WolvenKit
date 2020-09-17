using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimAnimsetsParam : CEntityTemplateParam
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("componentName")] 		public CString ComponentName { get; set;}

		[Ordinal(3)] [RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		public CAnimAnimsetsParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimAnimsetsParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
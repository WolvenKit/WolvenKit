using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimAnimsetsParam : CEntityTemplateParam
	{
		[Ordinal(1)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(2)] [RED("componentName")] 		public CString ComponentName { get; set;}

		[Ordinal(3)] [RED("animationSets", 2,0)] 		public CArray<CHandle<CSkeletalAnimationSet>> AnimationSets { get; set;}

		public CAnimAnimsetsParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
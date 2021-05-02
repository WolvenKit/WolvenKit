using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimGlobalParam : CEntityTemplateParam
	{
		[Ordinal(1)] [RED("skeletonType")] 		public CEnum<ESkeletonType> SkeletonType { get; set;}

		[Ordinal(2)] [RED("defaultAnimationName")] 		public CName DefaultAnimationName { get; set;}

		[Ordinal(3)] [RED("customMimicsFilter_Full")] 		public CName CustomMimicsFilter_Full { get; set;}

		[Ordinal(4)] [RED("customMimicsFilter_Lipsync")] 		public CName CustomMimicsFilter_Lipsync { get; set;}

		[Ordinal(5)] [RED("animTag")] 		public CName AnimTag { get; set;}

		[Ordinal(6)] [RED("sfxTag")] 		public CName SfxTag { get; set;}

		public CAnimGlobalParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimGlobalParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimationTrajectoryTrackParam : ISkeletalAnimationSetEntryParam
	{
		[Ordinal(1)] [RED("editorOnly")] 		public CBool EditorOnly { get; set;}

		[Ordinal(2)] [RED("names", 2,0)] 		public CArray<CName> Names { get; set;}

		[Ordinal(3)] [RED("datas", 2,0)] 		public CArray<CArray<Vector>> Datas { get; set;}

		public CSkeletalAnimationTrajectoryTrackParam(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimationTrajectoryTrackParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
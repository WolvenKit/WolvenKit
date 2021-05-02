using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CReactionAttitudeChange : IReactionAction
	{
		[Ordinal(1)] [RED("attitude")] 		public CEnum<EAIAttitude> Attitude { get; set;}

		[Ordinal(2)] [RED("towardSource")] 		public CBool TowardSource { get; set;}

		[Ordinal(3)] [RED("noticeActor")] 		public CBool NoticeActor { get; set;}

		public CReactionAttitudeChange(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CReactionAttitudeChange(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
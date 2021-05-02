using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAILeadPackWander : CAIDynamicWander
	{
		[Ordinal(1)] [RED("leaderRegroupEvent")] 		public CName LeaderRegroupEvent { get; set;}

		[Ordinal(2)] [RED("followers")] 		public CInt32 Followers { get; set;}

		[Ordinal(3)] [RED("canWanderRun")] 		public CBool CanWanderRun { get; set;}

		[Ordinal(4)] [RED("chanceToRun")] 		public CFloat ChanceToRun { get; set;}

		public CAILeadPackWander(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAILeadPackWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
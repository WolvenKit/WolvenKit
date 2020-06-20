using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIIdleSpontanousFormationTree : IAIIdleFormationTree
	{
		[RED("partyMemberName")] 		public CName PartyMemberName { get; set;}

		[RED("leaderSteering")] 		public CHandle<CMoveSteeringBehavior> LeaderSteering { get; set;}

		[RED("leadFormationTree")] 		public CHandle<CAIIdleTree> LeadFormationTree { get; set;}

		[RED("loneWolfTree")] 		public CHandle<CAIIdleTree> LoneWolfTree { get; set;}

		public CAIIdleSpontanousFormationTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIIdleSpontanousFormationTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
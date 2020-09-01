using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFormationLeadActionTree : IAIFormationActionTree
	{
		[Ordinal(1)] [RED("leaderSteering")] 		public CHandle<CMoveSteeringBehavior> LeaderSteering { get; set;}

		[Ordinal(2)] [RED("reshapeOnMoveAction")] 		public CBool ReshapeOnMoveAction { get; set;}

		[Ordinal(3)] [RED("leadSubtree")] 		public CHandle<IAIActionTree> LeadSubtree { get; set;}

		public CAIFormationLeadActionTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIFormationLeadActionTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
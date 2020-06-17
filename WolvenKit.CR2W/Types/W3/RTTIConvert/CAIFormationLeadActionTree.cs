using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIFormationLeadActionTree : IAIFormationActionTree
	{
		[RED("leaderSteering")] 		public CHandle<CMoveSteeringBehavior> LeaderSteering { get; set;}

		[RED("reshapeOnMoveAction")] 		public CBool ReshapeOnMoveAction { get; set;}

		[RED("leadSubtree")] 		public CHandle<IAIActionTree> LeadSubtree { get; set;}

		public CAIFormationLeadActionTree(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIFormationLeadActionTree(cr2w);

	}
}
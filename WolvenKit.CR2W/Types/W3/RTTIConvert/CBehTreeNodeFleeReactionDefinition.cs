using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeFleeReactionDefinition : CBehTreeNodeAtomicMoveToDefinition
	{
		[Ordinal(1)] [RED("fleeDistance")] 		public CBehTreeValFloat FleeDistance { get; set;}

		[Ordinal(2)] [RED("surrenderDistance")] 		public CBehTreeValFloat SurrenderDistance { get; set;}

		[Ordinal(3)] [RED("queryRadiusRatio")] 		public CFloat QueryRadiusRatio { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		public CBehTreeNodeFleeReactionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeFleeReactionDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
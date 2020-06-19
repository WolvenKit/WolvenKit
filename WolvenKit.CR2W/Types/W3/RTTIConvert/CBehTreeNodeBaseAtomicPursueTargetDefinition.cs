using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeBaseAtomicPursueTargetDefinition : CBehTreeNodeAtomicActionDefinition
	{
		[RED("minDistance")] 		public CBehTreeValFloat MinDistance { get; set;}

		[RED("moveSpeed")] 		public CBehTreeValFloat MoveSpeed { get; set;}

		[RED("tolerance")] 		public CBehTreeValFloat Tolerance { get; set;}

		[RED("moveType")] 		public CBehTreeValEMoveType MoveType { get; set;}

		[RED("moveOutsideNavdata")] 		public CBehTreeValBool MoveOutsideNavdata { get; set;}

		public CBehTreeNodeBaseAtomicPursueTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeBaseAtomicPursueTargetDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
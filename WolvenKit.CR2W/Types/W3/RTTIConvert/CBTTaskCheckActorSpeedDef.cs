using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckActorSpeedDef : IBehTreeTaskDefinition
	{
		[RED("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[RED("customSpeed")] 		public CBool CustomSpeed { get; set;}

		[RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		public CBTTaskCheckActorSpeedDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskCheckActorSpeedDef(cr2w);

	}
}
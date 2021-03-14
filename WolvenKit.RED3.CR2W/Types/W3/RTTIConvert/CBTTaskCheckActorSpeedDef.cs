using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskCheckActorSpeedDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("checkedActor")] 		public CEnum<EStatOwner> CheckedActor { get; set;}

		[Ordinal(2)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(3)] [RED("operator")] 		public CEnum<EOperator> Operator { get; set;}

		[Ordinal(4)] [RED("customSpeed")] 		public CBool CustomSpeed { get; set;}

		[Ordinal(5)] [RED("moveSpeed")] 		public CFloat MoveSpeed { get; set;}

		public CBTTaskCheckActorSpeedDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskCheckActorSpeedDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
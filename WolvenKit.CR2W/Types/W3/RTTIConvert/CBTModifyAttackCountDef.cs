using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTModifyAttackCountDef : IBehTreeConditionalTaskDefinition
	{
		[RED("attackName")] 		public CName AttackName { get; set;}

		[RED("incrementAttackCount")] 		public CBool IncrementAttackCount { get; set;}

		[RED("resetAttackCount")] 		public CBool ResetAttackCount { get; set;}

		public CBTModifyAttackCountDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTModifyAttackCountDef(cr2w);

	}
}
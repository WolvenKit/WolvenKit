using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SRestoredSkill : CVariable
	{
		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("skillType")] 		public ESkill SkillType { get; set;}

		[RED("isNew")] 		public CBool IsNew { get; set;}

		[RED("remainingBlockedTime")] 		public CFloat RemainingBlockedTime { get; set;}

		public SRestoredSkill(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SRestoredSkill(cr2w);

	}
}
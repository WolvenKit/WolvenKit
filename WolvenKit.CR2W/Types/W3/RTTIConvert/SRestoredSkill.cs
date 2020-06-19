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

		[RED("skillType")] 		public CEnum<ESkill> SkillType { get; set;}

		[RED("isNew")] 		public CBool IsNew { get; set;}

		[RED("remainingBlockedTime")] 		public CFloat RemainingBlockedTime { get; set;}

		public SRestoredSkill(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SRestoredSkill(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
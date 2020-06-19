using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAdditiveHitListenerDef : IBehTreeTaskDefinition
	{
		[RED("playHitSound")] 		public CBool PlayHitSound { get; set;}

		[RED("sounEventName")] 		public CString SounEventName { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("manageIgnoreSignsEvents")] 		public CBool ManageIgnoreSignsEvents { get; set;}

		[RED("angleToIgnoreSigns")] 		public CFloat AngleToIgnoreSigns { get; set;}

		[RED("chanceToUseAdditive")] 		public CFloat ChanceToUseAdditive { get; set;}

		[RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[RED("processCounter")] 		public CBool ProcessCounter { get; set;}

		public BTTaskAdditiveHitListenerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAdditiveHitListenerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
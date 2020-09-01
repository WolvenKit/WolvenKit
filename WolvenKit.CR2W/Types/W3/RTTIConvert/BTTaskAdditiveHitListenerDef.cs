using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAdditiveHitListenerDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("playHitSound")] 		public CBool PlayHitSound { get; set;}

		[Ordinal(0)] [RED("sounEventName")] 		public CString SounEventName { get; set;}

		[Ordinal(0)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("manageIgnoreSignsEvents")] 		public CBool ManageIgnoreSignsEvents { get; set;}

		[Ordinal(0)] [RED("angleToIgnoreSigns")] 		public CFloat AngleToIgnoreSigns { get; set;}

		[Ordinal(0)] [RED("chanceToUseAdditive")] 		public CFloat ChanceToUseAdditive { get; set;}

		[Ordinal(0)] [RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[Ordinal(0)] [RED("processCounter")] 		public CBool ProcessCounter { get; set;}

		public BTTaskAdditiveHitListenerDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAdditiveHitListenerDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
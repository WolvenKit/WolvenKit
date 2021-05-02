using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAdditiveHitListenerDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("playHitSound")] 		public CBool PlayHitSound { get; set;}

		[Ordinal(2)] [RED("sounEventName")] 		public CString SounEventName { get; set;}

		[Ordinal(3)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(4)] [RED("manageIgnoreSignsEvents")] 		public CBool ManageIgnoreSignsEvents { get; set;}

		[Ordinal(5)] [RED("angleToIgnoreSigns")] 		public CFloat AngleToIgnoreSigns { get; set;}

		[Ordinal(6)] [RED("chanceToUseAdditive")] 		public CFloat ChanceToUseAdditive { get; set;}

		[Ordinal(7)] [RED("increaseHitCounterOnlyOnMeleeDmg")] 		public CBool IncreaseHitCounterOnlyOnMeleeDmg { get; set;}

		[Ordinal(8)] [RED("processCounter")] 		public CBool ProcessCounter { get; set;}

		public BTTaskAdditiveHitListenerDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
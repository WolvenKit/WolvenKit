using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskUpdateLookatTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(2)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(3)] [RED("usePrediction")] 		public CBool UsePrediction { get; set;}

		[Ordinal(4)] [RED("useCustomTarget")] 		public CBool UseCustomTarget { get; set;}

		[Ordinal(5)] [RED("addZOffsetValue")] 		public CBool AddZOffsetValue { get; set;}

		[Ordinal(6)] [RED("disableLookAtOnDeath")] 		public CBool DisableLookAtOnDeath { get; set;}

		[Ordinal(7)] [RED("disableLookAtOnDeactivate")] 		public CBool DisableLookAtOnDeactivate { get; set;}

		public BTTaskUpdateLookatTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskUpdateLookatTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
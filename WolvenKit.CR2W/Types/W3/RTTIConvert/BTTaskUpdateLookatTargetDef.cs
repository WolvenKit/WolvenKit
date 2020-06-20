using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskUpdateLookatTargetDef : IBehTreeTaskDefinition
	{
		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("usePrediction")] 		public CBool UsePrediction { get; set;}

		[RED("useCustomTarget")] 		public CBool UseCustomTarget { get; set;}

		[RED("addZOffsetValue")] 		public CBool AddZOffsetValue { get; set;}

		[RED("disableLookAtOnDeath")] 		public CBool DisableLookAtOnDeath { get; set;}

		[RED("disableLookAtOnDeactivate")] 		public CBool DisableLookAtOnDeactivate { get; set;}

		public BTTaskUpdateLookatTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskUpdateLookatTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
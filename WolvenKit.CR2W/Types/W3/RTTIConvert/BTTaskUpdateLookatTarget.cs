using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskUpdateLookatTarget : IBehTreeTask
	{
		[RED("combatDataStorage")] 		public CHandle<CHumanAICombatStorage> CombatDataStorage { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("useCustomTarget")] 		public CBool UseCustomTarget { get; set;}

		[RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[RED("usePrediction")] 		public CBool UsePrediction { get; set;}

		[RED("addZOffsetValue")] 		public CBool AddZOffsetValue { get; set;}

		[RED("disableLookAtOnDeath")] 		public CBool DisableLookAtOnDeath { get; set;}

		[RED("disableLookAtOnDeactivate")] 		public CBool DisableLookAtOnDeactivate { get; set;}

		[RED("lookatTarget")] 		public CHandle<CNode> LookatTarget { get; set;}

		[RED("lookatActor")] 		public CHandle<CActor> LookatActor { get; set;}

		[RED("targetBoneIndex")] 		public CInt32 TargetBoneIndex { get; set;}

		[RED("targetPos")] 		public Vector TargetPos { get; set;}

		public BTTaskUpdateLookatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskUpdateLookatTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
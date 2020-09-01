using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskUpdateLookatTarget : IBehTreeTask
	{
		[Ordinal(1)] [RED("combatDataStorage")] 		public CHandle<CHumanAICombatStorage> CombatDataStorage { get; set;}

		[Ordinal(2)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(3)] [RED("useCustomTarget")] 		public CBool UseCustomTarget { get; set;}

		[Ordinal(4)] [RED("headBoneName")] 		public CName HeadBoneName { get; set;}

		[Ordinal(5)] [RED("usePrediction")] 		public CBool UsePrediction { get; set;}

		[Ordinal(6)] [RED("addZOffsetValue")] 		public CBool AddZOffsetValue { get; set;}

		[Ordinal(7)] [RED("disableLookAtOnDeath")] 		public CBool DisableLookAtOnDeath { get; set;}

		[Ordinal(8)] [RED("disableLookAtOnDeactivate")] 		public CBool DisableLookAtOnDeactivate { get; set;}

		[Ordinal(9)] [RED("lookatTarget")] 		public CHandle<CNode> LookatTarget { get; set;}

		[Ordinal(10)] [RED("lookatActor")] 		public CHandle<CActor> LookatActor { get; set;}

		[Ordinal(11)] [RED("targetBoneIndex")] 		public CInt32 TargetBoneIndex { get; set;}

		[Ordinal(12)] [RED("targetPos")] 		public Vector TargetPos { get; set;}

		public BTTaskUpdateLookatTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskUpdateLookatTarget(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
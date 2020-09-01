using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAddRemoveAbility : IBehTreeTask
	{
		[Ordinal(1)] [RED("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(2)] [RED("allowMultiple")] 		public CBool AllowMultiple { get; set;}

		[Ordinal(3)] [RED("removeAbility")] 		public CBool RemoveAbility { get; set;}

		[Ordinal(4)] [RED("delayUntilInCameraFrame")] 		public CBool DelayUntilInCameraFrame { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("onAnimEventName")] 		public CName OnAnimEventName { get; set;}

		[Ordinal(7)] [RED("eventReceived")] 		public CBool EventReceived { get; set;}

		public BTTaskAddRemoveAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAddRemoveAbility(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
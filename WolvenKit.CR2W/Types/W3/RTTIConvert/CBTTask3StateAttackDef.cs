using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTask3StateAttackDef : CBTTaskAttackDef
	{
		[RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[RED("endTaskWhenOwnerGoesPastTarget")] 		public CBool EndTaskWhenOwnerGoesPastTarget { get; set;}

		[RED("endLoopOnDistance")] 		public CBool EndLoopOnDistance { get; set;}

		[RED("distanceToTarget")] 		public CFloat DistanceToTarget { get; set;}

		[RED("stopRotatingWhenTargetIsBehind")] 		public CBool StopRotatingWhenTargetIsBehind { get; set;}

		[RED("playFXOnLoopStart")] 		public CName PlayFXOnLoopStart { get; set;}

		[RED("playLoopFXInterval")] 		public CFloat PlayLoopFXInterval { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("startDeactivationEventName")] 		public CName StartDeactivationEventName { get; set;}

		[RED("endDeactivationEventName")] 		public CName EndDeactivationEventName { get; set;}

		public CBTTask3StateAttackDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTask3StateAttackDef(cr2w);

	}
}
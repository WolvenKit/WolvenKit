using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CxplorationTransitionSwimToInteract : CExplorationStateTransitionAbstract
	{
		[Ordinal(1)] [RED("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(2)] [RED("transitionReadyToEnd")] 		public CBool TransitionReadyToEnd { get; set;}

		[Ordinal(3)] [RED("timeToTransition")] 		public CFloat TimeToTransition { get; set;}

		[Ordinal(4)] [RED("requireAngle")] 		public CBool RequireAngle { get; set;}

		[Ordinal(5)] [RED("timeToStopTrying")] 		public CFloat TimeToStopTrying { get; set;}

		[Ordinal(6)] [RED("locomotionSegment")] 		public CHandle<CR4LocomotionSwimToStop> LocomotionSegment { get; set;}

		[Ordinal(7)] [RED("animEventToBeReady")] 		public CName AnimEventToBeReady { get; set;}

		public CxplorationTransitionSwimToInteract(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CxplorationTransitionSwimToInteract(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
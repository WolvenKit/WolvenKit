using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMovingAgentComponent : CAnimatedComponent
	{
		[Ordinal(1)] [RED("ragdollRadius")] 		public CFloat RagdollRadius { get; set;}

		[Ordinal(2)] [RED("steeringBehavior")] 		public CHandle<CMoveSteeringBehavior> SteeringBehavior { get; set;}

		[Ordinal(3)] [RED("steeringControlledMovement")] 		public CBool SteeringControlledMovement { get; set;}

		[Ordinal(4)] [RED("snapToNavigableSpace")] 		public CBool SnapToNavigableSpace { get; set;}

		[Ordinal(5)] [RED("physicalRepresentation")] 		public CBool PhysicalRepresentation { get; set;}

		[Ordinal(6)] [RED("movementAdjustor")] 		public CPtr<CMovementAdjustor> MovementAdjustor { get; set;}

		[Ordinal(7)] [RED("triggerAutoActivator")] 		public CBool TriggerAutoActivator { get; set;}

		[Ordinal(8)] [RED("triggerActivatorRadius")] 		public CFloat TriggerActivatorRadius { get; set;}

		[Ordinal(9)] [RED("triggerActivatorHeight")] 		public CFloat TriggerActivatorHeight { get; set;}

		[Ordinal(10)] [RED("triggerChannels")] 		public CEnum<ETriggerChannel> TriggerChannels { get; set;}

		[Ordinal(11)] [RED("triggerEnableCCD")] 		public CBool TriggerEnableCCD { get; set;}

		[Ordinal(12)] [RED("triggerMaxSingleFrameDistance")] 		public CFloat TriggerMaxSingleFrameDistance { get; set;}

		[Ordinal(13)] [RED("relativeSpeedBuffer", 2,0)] 		public CArray<CFloat> RelativeSpeedBuffer { get; set;}

		public CMovingAgentComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMovingAgentComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMovingAgentComponent : CAnimatedComponent
	{
		[RED("ragdollRadius")] 		public CFloat RagdollRadius { get; set;}

		[RED("steeringBehavior")] 		public CHandle<CMoveSteeringBehavior> SteeringBehavior { get; set;}

		[RED("steeringControlledMovement")] 		public CBool SteeringControlledMovement { get; set;}

		[RED("snapToNavigableSpace")] 		public CBool SnapToNavigableSpace { get; set;}

		[RED("physicalRepresentation")] 		public CBool PhysicalRepresentation { get; set;}

		[RED("movementAdjustor")] 		public CPtr<CMovementAdjustor> MovementAdjustor { get; set;}

		[RED("triggerAutoActivator")] 		public CBool TriggerAutoActivator { get; set;}

		[RED("triggerActivatorRadius")] 		public CFloat TriggerActivatorRadius { get; set;}

		[RED("triggerActivatorHeight")] 		public CFloat TriggerActivatorHeight { get; set;}

		[RED("triggerChannels")] 		public ETriggerChannel TriggerChannels { get; set;}

		[RED("triggerEnableCCD")] 		public CBool TriggerEnableCCD { get; set;}

		[RED("triggerMaxSingleFrameDistance")] 		public CFloat TriggerMaxSingleFrameDistance { get; set;}

		public CMovingAgentComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMovingAgentComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
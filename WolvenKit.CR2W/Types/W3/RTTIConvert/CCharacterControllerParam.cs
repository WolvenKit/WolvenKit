using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCharacterControllerParam : CGameplayEntityParam
	{
		[RED("height")] 		public CFloat Height { get; set;}

		[RED("physicalRadius")] 		public CFloat PhysicalRadius { get; set;}

		[RED("baseVirtualCharacterRadius")] 		public CFloat BaseVirtualCharacterRadius { get; set;}

		[RED("customAvoidanceRadius")] 		public CFloat CustomAvoidanceRadius { get; set;}

		[RED("interactionPriority")] 		public CFloat InteractionPriority { get; set;}

		[RED("interactionPriorityEnum")] 		public EInteractionPriority InteractionPriorityEnum { get; set;}

		[RED("stepOffset")] 		public CFloat StepOffset { get; set;}

		[RED("collisionType")] 		public CPhysicalCollision CollisionType { get; set;}

		[RED("collisionPrediction")] 		public CBool CollisionPrediction { get; set;}

		[RED("collisionPredictionMovementAdd")] 		public CFloat CollisionPredictionMovementAdd { get; set;}

		[RED("collisionPredictionMovementMul")] 		public CFloat CollisionPredictionMovementMul { get; set;}

		[RED("collisionPredictionEventName")] 		public CName CollisionPredictionEventName { get; set;}

		[RED("radiuses", 2,0)] 		public CArray<SControllerRadiusParams> Radiuses { get; set;}

		[RED("virtualControllers", 2,0)] 		public CArray<SVirtualControllerParams> VirtualControllers { get; set;}

		[RED("customMovableRep")] 		public CPtr<CMovableRepresentationCreator> CustomMovableRep { get; set;}

		[RED("significance")] 		public CFloat Significance { get; set;}

		public CCharacterControllerParam(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CCharacterControllerParam(cr2w);

	}
}
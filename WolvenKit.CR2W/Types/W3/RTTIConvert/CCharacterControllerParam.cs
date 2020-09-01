using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCharacterControllerParam : CGameplayEntityParam
	{
		[Ordinal(1)] [RED("height")] 		public CFloat Height { get; set;}

		[Ordinal(2)] [RED("physicalRadius")] 		public CFloat PhysicalRadius { get; set;}

		[Ordinal(3)] [RED("baseVirtualCharacterRadius")] 		public CFloat BaseVirtualCharacterRadius { get; set;}

		[Ordinal(4)] [RED("customAvoidanceRadius")] 		public CFloat CustomAvoidanceRadius { get; set;}

		[Ordinal(5)] [RED("interactionPriority")] 		public CFloat InteractionPriority { get; set;}

		[Ordinal(6)] [RED("interactionPriorityEnum")] 		public CEnum<EInteractionPriority> InteractionPriorityEnum { get; set;}

		[Ordinal(7)] [RED("stepOffset")] 		public CFloat StepOffset { get; set;}

		[Ordinal(8)] [RED("collisionType")] 		public CPhysicalCollision CollisionType { get; set;}

		[Ordinal(9)] [RED("collisionPrediction")] 		public CBool CollisionPrediction { get; set;}

		[Ordinal(10)] [RED("collisionPredictionMovementAdd")] 		public CFloat CollisionPredictionMovementAdd { get; set;}

		[Ordinal(11)] [RED("collisionPredictionMovementMul")] 		public CFloat CollisionPredictionMovementMul { get; set;}

		[Ordinal(12)] [RED("collisionPredictionEventName")] 		public CName CollisionPredictionEventName { get; set;}

		[Ordinal(13)] [RED("radiuses", 2,0)] 		public CArray<SControllerRadiusParams> Radiuses { get; set;}

		[Ordinal(14)] [RED("virtualControllers", 2,0)] 		public CArray<SVirtualControllerParams> VirtualControllers { get; set;}

		[Ordinal(15)] [RED("customMovableRep")] 		public CPtr<CMovableRepresentationCreator> CustomMovableRep { get; set;}

		[Ordinal(16)] [RED("significance")] 		public CFloat Significance { get; set;}

		public CCharacterControllerParam(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCharacterControllerParam(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}
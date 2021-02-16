using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftDevice : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("advertismentNames")] public CArray<CName> AdvertismentNames { get; set; }
		[Ordinal(94)] [RED("advertisments")] public CArray<CHandle<entIPlacedComponent>> Advertisments { get; set; }
		[Ordinal(95)] [RED("movingPlatform")] public CHandle<gameMovingPlatform> MovingPlatform { get; set; }
		[Ordinal(96)] [RED("floors")] public CArray<ElevatorFloorSetup> Floors { get; set; }
		[Ordinal(97)] [RED("QuestSafeguardColliders")] public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders { get; set; }
		[Ordinal(98)] [RED("QuestSafeguardColliderNames")] public CArray<CName> QuestSafeguardColliderNames { get; set; }
		[Ordinal(99)] [RED("frontDoorOccluder")] public CHandle<entIPlacedComponent> FrontDoorOccluder { get; set; }
		[Ordinal(100)] [RED("backDoorOccluder")] public CHandle<entIPlacedComponent> BackDoorOccluder { get; set; }
		[Ordinal(101)] [RED("radioMesh")] public CHandle<entIPlacedComponent> RadioMesh { get; set; }
		[Ordinal(102)] [RED("radioDestroyed")] public CHandle<entIPlacedComponent> RadioDestroyed { get; set; }
		[Ordinal(103)] [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(104)] [RED("isLoadPerformed")] public CBool IsLoadPerformed { get; set; }

		public LiftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

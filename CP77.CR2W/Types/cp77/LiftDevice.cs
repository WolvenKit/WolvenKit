using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class LiftDevice : InteractiveMasterDevice
	{
		[Ordinal(84)]  [RED("advertismentNames")] public CArray<CName> AdvertismentNames { get; set; }
		[Ordinal(85)]  [RED("advertisments")] public CArray<CHandle<entIPlacedComponent>> Advertisments { get; set; }
		[Ordinal(86)]  [RED("movingPlatform")] public CHandle<gameMovingPlatform> MovingPlatform { get; set; }
		[Ordinal(87)]  [RED("floors")] public CArray<ElevatorFloorSetup> Floors { get; set; }
		[Ordinal(88)]  [RED("QuestSafeguardColliders")] public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders { get; set; }
		[Ordinal(89)]  [RED("QuestSafeguardColliderNames")] public CArray<CName> QuestSafeguardColliderNames { get; set; }
		[Ordinal(90)]  [RED("frontDoorOccluder")] public CHandle<entIPlacedComponent> FrontDoorOccluder { get; set; }
		[Ordinal(91)]  [RED("backDoorOccluder")] public CHandle<entIPlacedComponent> BackDoorOccluder { get; set; }
		[Ordinal(92)]  [RED("radioMesh")] public CHandle<entIPlacedComponent> RadioMesh { get; set; }
		[Ordinal(93)]  [RED("radioDestroyed")] public CHandle<entIPlacedComponent> RadioDestroyed { get; set; }
		[Ordinal(94)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(95)]  [RED("isLoadPerformed")] public CBool IsLoadPerformed { get; set; }

		public LiftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

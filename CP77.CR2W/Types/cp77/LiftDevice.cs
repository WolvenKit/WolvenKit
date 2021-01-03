using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class LiftDevice : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("QuestSafeguardColliderNames")] public CArray<CName> QuestSafeguardColliderNames { get; set; }
		[Ordinal(1)]  [RED("QuestSafeguardColliders")] public CArray<CHandle<entIPlacedComponent>> QuestSafeguardColliders { get; set; }
		[Ordinal(2)]  [RED("advertismentNames")] public CArray<CName> AdvertismentNames { get; set; }
		[Ordinal(3)]  [RED("advertisments")] public CArray<CHandle<entIPlacedComponent>> Advertisments { get; set; }
		[Ordinal(4)]  [RED("backDoorOccluder")] public CHandle<entIPlacedComponent> BackDoorOccluder { get; set; }
		[Ordinal(5)]  [RED("floors")] public CArray<ElevatorFloorSetup> Floors { get; set; }
		[Ordinal(6)]  [RED("frontDoorOccluder")] public CHandle<entIPlacedComponent> FrontDoorOccluder { get; set; }
		[Ordinal(7)]  [RED("isLoadPerformed")] public CBool IsLoadPerformed { get; set; }
		[Ordinal(8)]  [RED("movingPlatform")] public CHandle<gameMovingPlatform> MovingPlatform { get; set; }
		[Ordinal(9)]  [RED("offMeshConnectionComponent")] public CHandle<AIOffMeshConnectionComponent> OffMeshConnectionComponent { get; set; }
		[Ordinal(10)]  [RED("radioDestroyed")] public CHandle<entIPlacedComponent> RadioDestroyed { get; set; }
		[Ordinal(11)]  [RED("radioMesh")] public CHandle<entIPlacedComponent> RadioMesh { get; set; }

		public LiftDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

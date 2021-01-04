using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entColliderComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("colliders")] public CArray<CHandle<physicsICollider>> Colliders { get; set; }
		[Ordinal(1)]  [RED("comOffset")] public Transform ComOffset { get; set; }
		[Ordinal(2)]  [RED("dynamicTrafficSetting")] public TrafficGenDynamicTrafficSetting DynamicTrafficSetting { get; set; }
		[Ordinal(3)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(4)]  [RED("inertia")] public Vector3 Inertia { get; set; }
		[Ordinal(5)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(6)]  [RED("mass")] public CFloat Mass { get; set; }
		[Ordinal(7)]  [RED("massOverride")] public CFloat MassOverride { get; set; }
		[Ordinal(8)]  [RED("sendOnStoppedMovingEvents")] public CBool SendOnStoppedMovingEvents { get; set; }
		[Ordinal(9)]  [RED("shapes")] public CArray<CHandle<entColliderComponentShape>> Shapes { get; set; }
		[Ordinal(10)]  [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(11)]  [RED("startInactive")] public CBool StartInactive { get; set; }
		[Ordinal(12)]  [RED("useCCD")] public CBool UseCCD { get; set; }
		[Ordinal(13)]  [RED("volume")] public CFloat Volume { get; set; }

		public entColliderComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

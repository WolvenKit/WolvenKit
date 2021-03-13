using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalTriggerComponent : entIPlacedComponent
	{
		[Ordinal(5)] [RED("simulationType")] public CEnum<physicsSimulationType> SimulationType { get; set; }
		[Ordinal(6)] [RED("shape")] public physicsTriggerShape Shape { get; set; }
		[Ordinal(7)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(8)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entPhysicalTriggerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

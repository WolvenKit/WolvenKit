using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_PhysicalRay : gameEffectObjectProvider
	{
		[Ordinal(0)]  [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(1)]  [RED("inputForward")] public gameEffectInputParameter_Vector InputForward { get; set; }
		[Ordinal(2)]  [RED("inputPosition")] public gameEffectInputParameter_Vector InputPosition { get; set; }
		[Ordinal(3)]  [RED("inputRange")] public gameEffectInputParameter_Float InputRange { get; set; }
		[Ordinal(4)]  [RED("outputRaycastEnd")] public gameEffectOutputParameter_Vector OutputRaycastEnd { get; set; }

		public gameEffectObjectProvider_PhysicalRay(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

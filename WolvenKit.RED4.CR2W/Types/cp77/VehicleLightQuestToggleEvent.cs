using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleLightQuestToggleEvent : redEvent
	{
		[Ordinal(0)] [RED("toggle")] public CBool Toggle { get; set; }
		[Ordinal(1)] [RED("lightType")] public CEnum<vehicleELightType> LightType { get; set; }

		public VehicleLightQuestToggleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

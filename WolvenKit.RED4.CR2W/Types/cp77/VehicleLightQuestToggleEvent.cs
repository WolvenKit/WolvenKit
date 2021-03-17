using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleLightQuestToggleEvent : redEvent
	{
		private CBool _toggle;
		private CEnum<vehicleELightType> _lightType;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get => GetProperty(ref _lightType);
			set => SetProperty(ref _lightType, value);
		}

		public VehicleLightQuestToggleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

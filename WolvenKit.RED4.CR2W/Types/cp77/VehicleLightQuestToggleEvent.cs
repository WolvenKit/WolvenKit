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
			get
			{
				if (_toggle == null)
				{
					_toggle = (CBool) CR2WTypeManager.Create("Bool", "toggle", cr2w, this);
				}
				return _toggle;
			}
			set
			{
				if (_toggle == value)
				{
					return;
				}
				_toggle = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lightType")] 
		public CEnum<vehicleELightType> LightType
		{
			get
			{
				if (_lightType == null)
				{
					_lightType = (CEnum<vehicleELightType>) CR2WTypeManager.Create("vehicleELightType", "lightType", cr2w, this);
				}
				return _lightType;
			}
			set
			{
				if (_lightType == value)
				{
					return;
				}
				_lightType = value;
				PropertySet(this);
			}
		}

		public VehicleLightQuestToggleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

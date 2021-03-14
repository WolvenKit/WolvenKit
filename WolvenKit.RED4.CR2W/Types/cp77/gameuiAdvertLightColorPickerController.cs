using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAdvertLightColorPickerController : inkWidgetLogicController
	{
		private CColor _lightColor;

		[Ordinal(1)] 
		[RED("lightColor")] 
		public CColor LightColor
		{
			get
			{
				if (_lightColor == null)
				{
					_lightColor = (CColor) CR2WTypeManager.Create("Color", "lightColor", cr2w, this);
				}
				return _lightColor;
			}
			set
			{
				if (_lightColor == value)
				{
					return;
				}
				_lightColor = value;
				PropertySet(this);
			}
		}

		public gameuiAdvertLightColorPickerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _lightColor);
			set => SetProperty(ref _lightColor, value);
		}

		public gameuiAdvertLightColorPickerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDeviceMappinController : gameuiBaseMinimapMappinController
	{
		private inkCircleWidgetReference _effectAreaWidget;

		[Ordinal(14)] 
		[RED("effectAreaWidget")] 
		public inkCircleWidgetReference EffectAreaWidget
		{
			get => GetProperty(ref _effectAreaWidget);
			set => SetProperty(ref _effectAreaWidget, value);
		}

		public gameuiMinimapDeviceMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

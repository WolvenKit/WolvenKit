using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapQuestAreaMappinController : gameuiBaseMinimapMappinController
	{
		private inkShapeWidgetReference _areaShapeWidget;

		[Ordinal(14)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get => GetProperty(ref _areaShapeWidget);
			set => SetProperty(ref _areaShapeWidget, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapQuestAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get => GetPropertyValue<inkShapeWidgetReference>();
			set => SetPropertyValue<inkShapeWidgetReference>(value);
		}

		public gameuiMinimapQuestAreaMappinController()
		{
			AreaShapeWidget = new();
		}
	}
}

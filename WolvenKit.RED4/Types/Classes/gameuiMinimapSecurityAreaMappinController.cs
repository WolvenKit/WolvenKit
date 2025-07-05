using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("playerInArea")] 
		public CBool PlayerInArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("area")] 
		public CHandle<gamemappinsIArea> Area
		{
			get => GetPropertyValue<CHandle<gamemappinsIArea>>();
			set => SetPropertyValue<CHandle<gamemappinsIArea>>(value);
		}

		[Ordinal(16)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get => GetPropertyValue<inkShapeWidgetReference>();
			set => SetPropertyValue<inkShapeWidgetReference>(value);
		}

		public gameuiMinimapSecurityAreaMappinController()
		{
			AreaShapeWidget = new inkShapeWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

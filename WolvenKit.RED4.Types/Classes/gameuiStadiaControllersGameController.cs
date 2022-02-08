using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("stadiaControllerPage")] 
		public inkWidgetReference StadiaControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("nintendoControllerPage")] 
		public inkWidgetReference NintendoControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("durangoControllerPage")] 
		public inkWidgetReference DurangoControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("orbisControllerPage")] 
		public inkWidgetReference OrbisControllerPage
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiStadiaControllersGameController()
		{
			StadiaControllerPage = new();
			NintendoControllerPage = new();
			DurangoControllerPage = new();
			OrbisControllerPage = new();
		}
	}
}

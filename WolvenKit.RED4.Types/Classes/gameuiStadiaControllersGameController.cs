using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiStadiaControllersGameController : gameuiMenuGameController
	{
		private inkWidgetReference _stadiaControllerPage;
		private inkWidgetReference _nintendoControllerPage;
		private inkWidgetReference _durangoControllerPage;
		private inkWidgetReference _orbisControllerPage;

		[Ordinal(3)] 
		[RED("stadiaControllerPage")] 
		public inkWidgetReference StadiaControllerPage
		{
			get => GetProperty(ref _stadiaControllerPage);
			set => SetProperty(ref _stadiaControllerPage, value);
		}

		[Ordinal(4)] 
		[RED("nintendoControllerPage")] 
		public inkWidgetReference NintendoControllerPage
		{
			get => GetProperty(ref _nintendoControllerPage);
			set => SetProperty(ref _nintendoControllerPage, value);
		}

		[Ordinal(5)] 
		[RED("durangoControllerPage")] 
		public inkWidgetReference DurangoControllerPage
		{
			get => GetProperty(ref _durangoControllerPage);
			set => SetProperty(ref _durangoControllerPage, value);
		}

		[Ordinal(6)] 
		[RED("orbisControllerPage")] 
		public inkWidgetReference OrbisControllerPage
		{
			get => GetProperty(ref _orbisControllerPage);
			set => SetProperty(ref _orbisControllerPage, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStadiaControllersGameController : gameuiMenuGameController
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

		public gameuiStadiaControllersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

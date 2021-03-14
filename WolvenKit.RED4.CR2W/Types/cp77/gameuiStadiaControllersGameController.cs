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
			get
			{
				if (_stadiaControllerPage == null)
				{
					_stadiaControllerPage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "stadiaControllerPage", cr2w, this);
				}
				return _stadiaControllerPage;
			}
			set
			{
				if (_stadiaControllerPage == value)
				{
					return;
				}
				_stadiaControllerPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nintendoControllerPage")] 
		public inkWidgetReference NintendoControllerPage
		{
			get
			{
				if (_nintendoControllerPage == null)
				{
					_nintendoControllerPage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "nintendoControllerPage", cr2w, this);
				}
				return _nintendoControllerPage;
			}
			set
			{
				if (_nintendoControllerPage == value)
				{
					return;
				}
				_nintendoControllerPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("durangoControllerPage")] 
		public inkWidgetReference DurangoControllerPage
		{
			get
			{
				if (_durangoControllerPage == null)
				{
					_durangoControllerPage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "durangoControllerPage", cr2w, this);
				}
				return _durangoControllerPage;
			}
			set
			{
				if (_durangoControllerPage == value)
				{
					return;
				}
				_durangoControllerPage = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("orbisControllerPage")] 
		public inkWidgetReference OrbisControllerPage
		{
			get
			{
				if (_orbisControllerPage == null)
				{
					_orbisControllerPage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "orbisControllerPage", cr2w, this);
				}
				return _orbisControllerPage;
			}
			set
			{
				if (_orbisControllerPage == value)
				{
					return;
				}
				_orbisControllerPage = value;
				PropertySet(this);
			}
		}

		public gameuiStadiaControllersGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

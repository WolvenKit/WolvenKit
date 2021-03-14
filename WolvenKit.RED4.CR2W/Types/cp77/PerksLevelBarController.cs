using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerksLevelBarController : inkWidgetLogicController
	{
		private inkWidgetReference _foregroundImage;
		private inkWidgetReference _backgroundImage;

		[Ordinal(1)] 
		[RED("foregroundImage")] 
		public inkWidgetReference ForegroundImage
		{
			get
			{
				if (_foregroundImage == null)
				{
					_foregroundImage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "foregroundImage", cr2w, this);
				}
				return _foregroundImage;
			}
			set
			{
				if (_foregroundImage == value)
				{
					return;
				}
				_foregroundImage = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("backgroundImage")] 
		public inkWidgetReference BackgroundImage
		{
			get
			{
				if (_backgroundImage == null)
				{
					_backgroundImage = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "backgroundImage", cr2w, this);
				}
				return _backgroundImage;
			}
			set
			{
				if (_backgroundImage == value)
				{
					return;
				}
				_backgroundImage = value;
				PropertySet(this);
			}
		}

		public PerksLevelBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

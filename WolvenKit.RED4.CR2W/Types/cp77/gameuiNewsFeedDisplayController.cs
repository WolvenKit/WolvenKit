using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewsFeedDisplayController : inkWidgetLogicController
	{
		private inkTextWidgetReference _newsTitleWidget;
		private CName _randomNewsLibraryWidget;
		private inkCompoundWidgetReference _randomNewsContainer;

		[Ordinal(1)] 
		[RED("newsTitleWidget")] 
		public inkTextWidgetReference NewsTitleWidget
		{
			get
			{
				if (_newsTitleWidget == null)
				{
					_newsTitleWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "newsTitleWidget", cr2w, this);
				}
				return _newsTitleWidget;
			}
			set
			{
				if (_newsTitleWidget == value)
				{
					return;
				}
				_newsTitleWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("randomNewsLibraryWidget")] 
		public CName RandomNewsLibraryWidget
		{
			get
			{
				if (_randomNewsLibraryWidget == null)
				{
					_randomNewsLibraryWidget = (CName) CR2WTypeManager.Create("CName", "randomNewsLibraryWidget", cr2w, this);
				}
				return _randomNewsLibraryWidget;
			}
			set
			{
				if (_randomNewsLibraryWidget == value)
				{
					return;
				}
				_randomNewsLibraryWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("randomNewsContainer")] 
		public inkCompoundWidgetReference RandomNewsContainer
		{
			get
			{
				if (_randomNewsContainer == null)
				{
					_randomNewsContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "randomNewsContainer", cr2w, this);
				}
				return _randomNewsContainer;
			}
			set
			{
				if (_randomNewsContainer == value)
				{
					return;
				}
				_randomNewsContainer = value;
				PropertySet(this);
			}
		}

		public gameuiNewsFeedDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

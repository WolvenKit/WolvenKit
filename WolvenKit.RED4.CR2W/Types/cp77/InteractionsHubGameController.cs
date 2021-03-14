using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractionsHubGameController : gameuiHUDGameController
	{
		private CArray<inkWidgetLibraryReference> _topInteractionWidgetsLibraries;
		private inkWidgetReference _topInteractionsRoot;
		private CArray<inkWidgetLibraryReference> _botInteractionWidgetsLibraries;
		private inkWidgetReference _botInteractionsRoot;
		private inkWidgetReference _tooltipsManagerRef;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;

		[Ordinal(9)] 
		[RED("TopInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> TopInteractionWidgetsLibraries
		{
			get
			{
				if (_topInteractionWidgetsLibraries == null)
				{
					_topInteractionWidgetsLibraries = (CArray<inkWidgetLibraryReference>) CR2WTypeManager.Create("array:inkWidgetLibraryReference", "TopInteractionWidgetsLibraries", cr2w, this);
				}
				return _topInteractionWidgetsLibraries;
			}
			set
			{
				if (_topInteractionWidgetsLibraries == value)
				{
					return;
				}
				_topInteractionWidgetsLibraries = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("TopInteractionsRoot")] 
		public inkWidgetReference TopInteractionsRoot
		{
			get
			{
				if (_topInteractionsRoot == null)
				{
					_topInteractionsRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TopInteractionsRoot", cr2w, this);
				}
				return _topInteractionsRoot;
			}
			set
			{
				if (_topInteractionsRoot == value)
				{
					return;
				}
				_topInteractionsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("BotInteractionWidgetsLibraries")] 
		public CArray<inkWidgetLibraryReference> BotInteractionWidgetsLibraries
		{
			get
			{
				if (_botInteractionWidgetsLibraries == null)
				{
					_botInteractionWidgetsLibraries = (CArray<inkWidgetLibraryReference>) CR2WTypeManager.Create("array:inkWidgetLibraryReference", "BotInteractionWidgetsLibraries", cr2w, this);
				}
				return _botInteractionWidgetsLibraries;
			}
			set
			{
				if (_botInteractionWidgetsLibraries == value)
				{
					return;
				}
				_botInteractionWidgetsLibraries = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("BotInteractionsRoot")] 
		public inkWidgetReference BotInteractionsRoot
		{
			get
			{
				if (_botInteractionsRoot == null)
				{
					_botInteractionsRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "BotInteractionsRoot", cr2w, this);
				}
				return _botInteractionsRoot;
			}
			set
			{
				if (_botInteractionsRoot == value)
				{
					return;
				}
				_botInteractionsRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		public InteractionsHubGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

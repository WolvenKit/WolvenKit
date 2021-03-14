using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTooltipsManager : inkWidgetLogicController
	{
		private inkWidgetReference _tooltipsContainer;
		private CBool _flipX;
		private CBool _flipY;
		private inkMargin _rootMargin;
		private inkMargin _screenMargin;
		private CArray<inkWidgetReference> _tooltipRequesters;
		private redResourceReferenceScriptToken _tooltipsLibrary;
		private CArray<CName> _genericTooltipsNames;
		private CArray<TooltipWidgetReference> _tooltipLibrariesReferences;
		private CArray<TooltipWidgetStyledReference> _tooltipLibrariesStyledReferences;
		private redResourceReferenceScriptToken _menuTooltipStylePath;
		private redResourceReferenceScriptToken _hudTooltipStylePath;
		private CArray<wCHandle<AGenericTooltipController>> _indexedTooltips;
		private CArray<CHandle<NamedTooltipController>> _namedTooltips;
		private redResourceReferenceScriptToken _tooltipStylePath;
		private CHandle<inkanimProxy> _introAnim;

		[Ordinal(1)] 
		[RED("tooltipsContainer")] 
		public inkWidgetReference TooltipsContainer
		{
			get
			{
				if (_tooltipsContainer == null)
				{
					_tooltipsContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "tooltipsContainer", cr2w, this);
				}
				return _tooltipsContainer;
			}
			set
			{
				if (_tooltipsContainer == value)
				{
					return;
				}
				_tooltipsContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("flipX")] 
		public CBool FlipX
		{
			get
			{
				if (_flipX == null)
				{
					_flipX = (CBool) CR2WTypeManager.Create("Bool", "flipX", cr2w, this);
				}
				return _flipX;
			}
			set
			{
				if (_flipX == value)
				{
					return;
				}
				_flipX = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flipY")] 
		public CBool FlipY
		{
			get
			{
				if (_flipY == null)
				{
					_flipY = (CBool) CR2WTypeManager.Create("Bool", "flipY", cr2w, this);
				}
				return _flipY;
			}
			set
			{
				if (_flipY == value)
				{
					return;
				}
				_flipY = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("rootMargin")] 
		public inkMargin RootMargin
		{
			get
			{
				if (_rootMargin == null)
				{
					_rootMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "rootMargin", cr2w, this);
				}
				return _rootMargin;
			}
			set
			{
				if (_rootMargin == value)
				{
					return;
				}
				_rootMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("screenMargin")] 
		public inkMargin ScreenMargin
		{
			get
			{
				if (_screenMargin == null)
				{
					_screenMargin = (inkMargin) CR2WTypeManager.Create("inkMargin", "screenMargin", cr2w, this);
				}
				return _screenMargin;
			}
			set
			{
				if (_screenMargin == value)
				{
					return;
				}
				_screenMargin = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("TooltipRequesters")] 
		public CArray<inkWidgetReference> TooltipRequesters
		{
			get
			{
				if (_tooltipRequesters == null)
				{
					_tooltipRequesters = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "TooltipRequesters", cr2w, this);
				}
				return _tooltipRequesters;
			}
			set
			{
				if (_tooltipRequesters == value)
				{
					return;
				}
				_tooltipRequesters = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("TooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get
			{
				if (_tooltipsLibrary == null)
				{
					_tooltipsLibrary = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "TooltipsLibrary", cr2w, this);
				}
				return _tooltipsLibrary;
			}
			set
			{
				if (_tooltipsLibrary == value)
				{
					return;
				}
				_tooltipsLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("GenericTooltipsNames")] 
		public CArray<CName> GenericTooltipsNames
		{
			get
			{
				if (_genericTooltipsNames == null)
				{
					_genericTooltipsNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "GenericTooltipsNames", cr2w, this);
				}
				return _genericTooltipsNames;
			}
			set
			{
				if (_genericTooltipsNames == value)
				{
					return;
				}
				_genericTooltipsNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("TooltipLibrariesReferences")] 
		public CArray<TooltipWidgetReference> TooltipLibrariesReferences
		{
			get
			{
				if (_tooltipLibrariesReferences == null)
				{
					_tooltipLibrariesReferences = (CArray<TooltipWidgetReference>) CR2WTypeManager.Create("array:TooltipWidgetReference", "TooltipLibrariesReferences", cr2w, this);
				}
				return _tooltipLibrariesReferences;
			}
			set
			{
				if (_tooltipLibrariesReferences == value)
				{
					return;
				}
				_tooltipLibrariesReferences = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("TooltipLibrariesStyledReferences")] 
		public CArray<TooltipWidgetStyledReference> TooltipLibrariesStyledReferences
		{
			get
			{
				if (_tooltipLibrariesStyledReferences == null)
				{
					_tooltipLibrariesStyledReferences = (CArray<TooltipWidgetStyledReference>) CR2WTypeManager.Create("array:TooltipWidgetStyledReference", "TooltipLibrariesStyledReferences", cr2w, this);
				}
				return _tooltipLibrariesStyledReferences;
			}
			set
			{
				if (_tooltipLibrariesStyledReferences == value)
				{
					return;
				}
				_tooltipLibrariesStyledReferences = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("MenuTooltipStylePath")] 
		public redResourceReferenceScriptToken MenuTooltipStylePath
		{
			get
			{
				if (_menuTooltipStylePath == null)
				{
					_menuTooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "MenuTooltipStylePath", cr2w, this);
				}
				return _menuTooltipStylePath;
			}
			set
			{
				if (_menuTooltipStylePath == value)
				{
					return;
				}
				_menuTooltipStylePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("HudTooltipStylePath")] 
		public redResourceReferenceScriptToken HudTooltipStylePath
		{
			get
			{
				if (_hudTooltipStylePath == null)
				{
					_hudTooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "HudTooltipStylePath", cr2w, this);
				}
				return _hudTooltipStylePath;
			}
			set
			{
				if (_hudTooltipStylePath == value)
				{
					return;
				}
				_hudTooltipStylePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("IndexedTooltips")] 
		public CArray<wCHandle<AGenericTooltipController>> IndexedTooltips
		{
			get
			{
				if (_indexedTooltips == null)
				{
					_indexedTooltips = (CArray<wCHandle<AGenericTooltipController>>) CR2WTypeManager.Create("array:whandle:AGenericTooltipController", "IndexedTooltips", cr2w, this);
				}
				return _indexedTooltips;
			}
			set
			{
				if (_indexedTooltips == value)
				{
					return;
				}
				_indexedTooltips = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("NamedTooltips")] 
		public CArray<CHandle<NamedTooltipController>> NamedTooltips
		{
			get
			{
				if (_namedTooltips == null)
				{
					_namedTooltips = (CArray<CHandle<NamedTooltipController>>) CR2WTypeManager.Create("array:handle:NamedTooltipController", "NamedTooltips", cr2w, this);
				}
				return _namedTooltips;
			}
			set
			{
				if (_namedTooltips == value)
				{
					return;
				}
				_namedTooltips = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("TooltipStylePath")] 
		public redResourceReferenceScriptToken TooltipStylePath
		{
			get
			{
				if (_tooltipStylePath == null)
				{
					_tooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "TooltipStylePath", cr2w, this);
				}
				return _tooltipStylePath;
			}
			set
			{
				if (_tooltipStylePath == value)
				{
					return;
				}
				_tooltipStylePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get
			{
				if (_introAnim == null)
				{
					_introAnim = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introAnim", cr2w, this);
				}
				return _introAnim;
			}
			set
			{
				if (_introAnim == value)
				{
					return;
				}
				_introAnim = value;
				PropertySet(this);
			}
		}

		public gameuiTooltipsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

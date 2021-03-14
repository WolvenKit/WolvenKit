using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkDebugLayerEntry : CVariable
	{
		private raRef<inkWidgetLibraryResource> _widgetResource;
		private CEnum<inkEAnchor> _anchorPlace;
		private Vector2 _anchorPoint;

		[Ordinal(0)] 
		[RED("widgetResource")] 
		public raRef<inkWidgetLibraryResource> WidgetResource
		{
			get
			{
				if (_widgetResource == null)
				{
					_widgetResource = (raRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("raRef:inkWidgetLibraryResource", "widgetResource", cr2w, this);
				}
				return _widgetResource;
			}
			set
			{
				if (_widgetResource == value)
				{
					return;
				}
				_widgetResource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("anchorPlace")] 
		public CEnum<inkEAnchor> AnchorPlace
		{
			get
			{
				if (_anchorPlace == null)
				{
					_anchorPlace = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "anchorPlace", cr2w, this);
				}
				return _anchorPlace;
			}
			set
			{
				if (_anchorPlace == value)
				{
					return;
				}
				_anchorPlace = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("anchorPoint")] 
		public Vector2 AnchorPoint
		{
			get
			{
				if (_anchorPoint == null)
				{
					_anchorPoint = (Vector2) CR2WTypeManager.Create("Vector2", "anchorPoint", cr2w, this);
				}
				return _anchorPoint;
			}
			set
			{
				if (_anchorPoint == value)
				{
					return;
				}
				_anchorPoint = value;
				PropertySet(this);
			}
		}

		public inkDebugLayerEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapLegendController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _list;
		private CBool _initialized;
		private CBool _visible;

		[Ordinal(1)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get
			{
				if (_list == null)
				{
					_list = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "list", cr2w, this);
				}
				return _list;
			}
			set
			{
				if (_list == value)
				{
					return;
				}
				_list = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CBool) CR2WTypeManager.Create("Bool", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visible")] 
		public CBool Visible
		{
			get
			{
				if (_visible == null)
				{
					_visible = (CBool) CR2WTypeManager.Create("Bool", "visible", cr2w, this);
				}
				return _visible;
			}
			set
			{
				if (_visible == value)
				{
					return;
				}
				_visible = value;
				PropertySet(this);
			}
		}

		public WorldMapLegendController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

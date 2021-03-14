using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudCorpoController : gameuiHUDGameController
	{
		private inkTextWidgetReference _scrollText;
		private inkWidgetReference _scrollTextWidget;
		private inkWidgetReference _root_canvas;
		private wCHandle<inkCompoundWidget> _root;
		private CUInt32 _fact1ListenerId;
		private CUInt32 _fact2ListenerId;
		private CUInt32 _fact3ListenerId;
		private CUInt32 _fact4ListenerId;
		private CUInt32 _fact5ListenerId;

		[Ordinal(9)] 
		[RED("ScrollText")] 
		public inkTextWidgetReference ScrollText
		{
			get
			{
				if (_scrollText == null)
				{
					_scrollText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "ScrollText", cr2w, this);
				}
				return _scrollText;
			}
			set
			{
				if (_scrollText == value)
				{
					return;
				}
				_scrollText = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("ScrollTextWidget")] 
		public inkWidgetReference ScrollTextWidget
		{
			get
			{
				if (_scrollTextWidget == null)
				{
					_scrollTextWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "ScrollTextWidget", cr2w, this);
				}
				return _scrollTextWidget;
			}
			set
			{
				if (_scrollTextWidget == value)
				{
					return;
				}
				_scrollTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root_canvas")] 
		public inkWidgetReference Root_canvas
		{
			get
			{
				if (_root_canvas == null)
				{
					_root_canvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root_canvas", cr2w, this);
				}
				return _root_canvas;
			}
			set
			{
				if (_root_canvas == value)
				{
					return;
				}
				_root_canvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get
			{
				if (_fact1ListenerId == null)
				{
					_fact1ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact1ListenerId", cr2w, this);
				}
				return _fact1ListenerId;
			}
			set
			{
				if (_fact1ListenerId == value)
				{
					return;
				}
				_fact1ListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get
			{
				if (_fact2ListenerId == null)
				{
					_fact2ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact2ListenerId", cr2w, this);
				}
				return _fact2ListenerId;
			}
			set
			{
				if (_fact2ListenerId == value)
				{
					return;
				}
				_fact2ListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("fact3ListenerId")] 
		public CUInt32 Fact3ListenerId
		{
			get
			{
				if (_fact3ListenerId == null)
				{
					_fact3ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact3ListenerId", cr2w, this);
				}
				return _fact3ListenerId;
			}
			set
			{
				if (_fact3ListenerId == value)
				{
					return;
				}
				_fact3ListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fact4ListenerId")] 
		public CUInt32 Fact4ListenerId
		{
			get
			{
				if (_fact4ListenerId == null)
				{
					_fact4ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact4ListenerId", cr2w, this);
				}
				return _fact4ListenerId;
			}
			set
			{
				if (_fact4ListenerId == value)
				{
					return;
				}
				_fact4ListenerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("fact5ListenerId")] 
		public CUInt32 Fact5ListenerId
		{
			get
			{
				if (_fact5ListenerId == null)
				{
					_fact5ListenerId = (CUInt32) CR2WTypeManager.Create("Uint32", "fact5ListenerId", cr2w, this);
				}
				return _fact5ListenerId;
			}
			set
			{
				if (_fact5ListenerId == value)
				{
					return;
				}
				_fact5ListenerId = value;
				PropertySet(this);
			}
		}

		public hudCorpoController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

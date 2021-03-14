using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamagePreviewController : inkWidgetLogicController
	{
		private inkWidgetReference _fullBar;
		private inkWidgetReference _stippedBar;
		private inkWidgetReference _rootCanvas;
		private CFloat _width;
		private CFloat _height;
		private CFloat _heightStripped;
		private CFloat _heightRoot;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get
			{
				if (_fullBar == null)
				{
					_fullBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fullBar", cr2w, this);
				}
				return _fullBar;
			}
			set
			{
				if (_fullBar == value)
				{
					return;
				}
				_fullBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stippedBar")] 
		public inkWidgetReference StippedBar
		{
			get
			{
				if (_stippedBar == null)
				{
					_stippedBar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "stippedBar", cr2w, this);
				}
				return _stippedBar;
			}
			set
			{
				if (_stippedBar == value)
				{
					return;
				}
				_stippedBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rootCanvas")] 
		public inkWidgetReference RootCanvas
		{
			get
			{
				if (_rootCanvas == null)
				{
					_rootCanvas = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rootCanvas", cr2w, this);
				}
				return _rootCanvas;
			}
			set
			{
				if (_rootCanvas == value)
				{
					return;
				}
				_rootCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CFloat Width
		{
			get
			{
				if (_width == null)
				{
					_width = (CFloat) CR2WTypeManager.Create("Float", "width", cr2w, this);
				}
				return _width;
			}
			set
			{
				if (_width == value)
				{
					return;
				}
				_width = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CFloat Height
		{
			get
			{
				if (_height == null)
				{
					_height = (CFloat) CR2WTypeManager.Create("Float", "height", cr2w, this);
				}
				return _height;
			}
			set
			{
				if (_height == value)
				{
					return;
				}
				_height = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("heightStripped")] 
		public CFloat HeightStripped
		{
			get
			{
				if (_heightStripped == null)
				{
					_heightStripped = (CFloat) CR2WTypeManager.Create("Float", "heightStripped", cr2w, this);
				}
				return _heightStripped;
			}
			set
			{
				if (_heightStripped == value)
				{
					return;
				}
				_heightStripped = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("heightRoot")] 
		public CFloat HeightRoot
		{
			get
			{
				if (_heightRoot == null)
				{
					_heightRoot = (CFloat) CR2WTypeManager.Create("Float", "heightRoot", cr2w, this);
				}
				return _heightRoot;
			}
			set
			{
				if (_heightRoot == value)
				{
					return;
				}
				_heightRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		public DamagePreviewController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

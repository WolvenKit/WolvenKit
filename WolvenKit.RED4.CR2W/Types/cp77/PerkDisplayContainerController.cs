using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerController : inkWidgetLogicController
	{
		private CInt32 _index;
		private CBool _isTrait;
		private inkWidgetReference _widget;
		private CHandle<BasePerkDisplayData> _data;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private CHandle<PerkDisplayController> _controller;

		[Ordinal(1)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isTrait")] 
		public CBool IsTrait
		{
			get
			{
				if (_isTrait == null)
				{
					_isTrait = (CBool) CR2WTypeManager.Create("Bool", "isTrait", cr2w, this);
				}
				return _isTrait;
			}
			set
			{
				if (_isTrait == value)
				{
					return;
				}
				_isTrait = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<BasePerkDisplayData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<BasePerkDisplayData>) CR2WTypeManager.Create("handle:BasePerkDisplayData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (CHandle<PlayerDevelopmentDataManager>) CR2WTypeManager.Create("handle:PlayerDevelopmentDataManager", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("controller")] 
		public CHandle<PerkDisplayController> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (CHandle<PerkDisplayController>) CR2WTypeManager.Create("handle:PerkDisplayController", "controller", cr2w, this);
				}
				return _controller;
			}
			set
			{
				if (_controller == value)
				{
					return;
				}
				_controller = value;
				PropertySet(this);
			}
		}

		public PerkDisplayContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

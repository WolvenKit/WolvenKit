using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AsyncSpawnData : IScriptable
	{
		private wCHandle<IScriptable> _callbackTarget;
		private wCHandle<IScriptable> _controller;
		private CName _functionName;
		private CName _libraryID;
		private CVariant _widgetData;

		[Ordinal(0)] 
		[RED("callbackTarget")] 
		public wCHandle<IScriptable> CallbackTarget
		{
			get
			{
				if (_callbackTarget == null)
				{
					_callbackTarget = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "callbackTarget", cr2w, this);
				}
				return _callbackTarget;
			}
			set
			{
				if (_callbackTarget == value)
				{
					return;
				}
				_callbackTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("controller")] 
		public wCHandle<IScriptable> Controller
		{
			get
			{
				if (_controller == null)
				{
					_controller = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "controller", cr2w, this);
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

		[Ordinal(2)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get
			{
				if (_functionName == null)
				{
					_functionName = (CName) CR2WTypeManager.Create("CName", "functionName", cr2w, this);
				}
				return _functionName;
			}
			set
			{
				if (_functionName == value)
				{
					return;
				}
				_functionName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("libraryID")] 
		public CName LibraryID
		{
			get
			{
				if (_libraryID == null)
				{
					_libraryID = (CName) CR2WTypeManager.Create("CName", "libraryID", cr2w, this);
				}
				return _libraryID;
			}
			set
			{
				if (_libraryID == value)
				{
					return;
				}
				_libraryID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("widgetData")] 
		public CVariant WidgetData
		{
			get
			{
				if (_widgetData == null)
				{
					_widgetData = (CVariant) CR2WTypeManager.Create("Variant", "widgetData", cr2w, this);
				}
				return _widgetData;
			}
			set
			{
				if (_widgetData == value)
				{
					return;
				}
				_widgetData = value;
				PropertySet(this);
			}
		}

		public AsyncSpawnData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

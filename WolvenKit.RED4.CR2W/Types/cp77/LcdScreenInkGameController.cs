using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkLeafWidget> _backgroundWidget;
		private wCHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onMessegeChangedListener;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public wCHandle<inkCanvasWidget> DefaultUI
		{
			get
			{
				if (_defaultUI == null)
				{
					_defaultUI = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "defaultUI", cr2w, this);
				}
				return _defaultUI;
			}
			set
			{
				if (_defaultUI == value)
				{
					return;
				}
				_defaultUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get
			{
				if (_mainDisplayWidget == null)
				{
					_mainDisplayWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "mainDisplayWidget", cr2w, this);
				}
				return _mainDisplayWidget;
			}
			set
			{
				if (_mainDisplayWidget == value)
				{
					return;
				}
				_mainDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get
			{
				if (_messegeWidget == null)
				{
					_messegeWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "messegeWidget", cr2w, this);
				}
				return _messegeWidget;
			}
			set
			{
				if (_messegeWidget == value)
				{
					return;
				}
				_messegeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("backgroundWidget")] 
		public wCHandle<inkLeafWidget> BackgroundWidget
		{
			get
			{
				if (_backgroundWidget == null)
				{
					_backgroundWidget = (wCHandle<inkLeafWidget>) CR2WTypeManager.Create("whandle:inkLeafWidget", "backgroundWidget", cr2w, this);
				}
				return _backgroundWidget;
			}
			set
			{
				if (_backgroundWidget == value)
				{
					return;
				}
				_backgroundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("messegeRecord")] 
		public wCHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get
			{
				if (_messegeRecord == null)
				{
					_messegeRecord = (wCHandle<gamedataScreenMessageData_Record>) CR2WTypeManager.Create("whandle:gamedataScreenMessageData_Record", "messegeRecord", cr2w, this);
				}
				return _messegeRecord;
			}
			set
			{
				if (_messegeRecord == value)
				{
					return;
				}
				_messegeRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get
			{
				if (_replaceTextWithCustomNumber == null)
				{
					_replaceTextWithCustomNumber = (CBool) CR2WTypeManager.Create("Bool", "replaceTextWithCustomNumber", cr2w, this);
				}
				return _replaceTextWithCustomNumber;
			}
			set
			{
				if (_replaceTextWithCustomNumber == value)
				{
					return;
				}
				_replaceTextWithCustomNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get
			{
				if (_customNumber == null)
				{
					_customNumber = (CInt32) CR2WTypeManager.Create("Int32", "customNumber", cr2w, this);
				}
				return _customNumber;
			}
			set
			{
				if (_customNumber == value)
				{
					return;
				}
				_customNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("onMessegeChangedListener")] 
		public CUInt32 OnMessegeChangedListener
		{
			get
			{
				if (_onMessegeChangedListener == null)
				{
					_onMessegeChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onMessegeChangedListener", cr2w, this);
				}
				return _onMessegeChangedListener;
			}
			set
			{
				if (_onMessegeChangedListener == value)
				{
					return;
				}
				_onMessegeChangedListener = value;
				PropertySet(this);
			}
		}

		public LcdScreenInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

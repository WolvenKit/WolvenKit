using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConfessionalInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkTextWidget> _defaultTextWidget;
		private wCHandle<inkWidget> _actionsList;
		private CHandle<inkanimProxy> _runningAnimation;
		private CBool _isConfessing;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onConfessListener;

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
		[RED("defaultTextWidget")] 
		public wCHandle<inkTextWidget> DefaultTextWidget
		{
			get
			{
				if (_defaultTextWidget == null)
				{
					_defaultTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "defaultTextWidget", cr2w, this);
				}
				return _defaultTextWidget;
			}
			set
			{
				if (_defaultTextWidget == value)
				{
					return;
				}
				_defaultTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("actionsList")] 
		public wCHandle<inkWidget> ActionsList
		{
			get
			{
				if (_actionsList == null)
				{
					_actionsList = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "actionsList", cr2w, this);
				}
				return _actionsList;
			}
			set
			{
				if (_actionsList == value)
				{
					return;
				}
				_actionsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get
			{
				if (_runningAnimation == null)
				{
					_runningAnimation = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "RunningAnimation", cr2w, this);
				}
				return _runningAnimation;
			}
			set
			{
				if (_runningAnimation == value)
				{
					return;
				}
				_runningAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("isConfessing")] 
		public CBool IsConfessing
		{
			get
			{
				if (_isConfessing == null)
				{
					_isConfessing = (CBool) CR2WTypeManager.Create("Bool", "isConfessing", cr2w, this);
				}
				return _isConfessing;
			}
			set
			{
				if (_isConfessing == value)
				{
					return;
				}
				_isConfessing = value;
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
		[RED("onConfessListener")] 
		public CUInt32 OnConfessListener
		{
			get
			{
				if (_onConfessListener == null)
				{
					_onConfessListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onConfessListener", cr2w, this);
				}
				return _onConfessListener;
			}
			set
			{
				if (_onConfessListener == value)
				{
					return;
				}
				_onConfessListener = value;
				PropertySet(this);
			}
		}

		public ConfessionalInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

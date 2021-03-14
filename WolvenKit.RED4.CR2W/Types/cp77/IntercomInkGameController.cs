using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IntercomInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _actionsList;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private CHandle<CallActionWidgetController> _buttonRef;
		private CEnum<IntercomStatus> _state;
		private CUInt32 _onUpdateStatusListener;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("actionsList")] 
		public inkWidgetReference ActionsList
		{
			get
			{
				if (_actionsList == null)
				{
					_actionsList = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "actionsList", cr2w, this);
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
		[RED("buttonRef")] 
		public CHandle<CallActionWidgetController> ButtonRef
		{
			get
			{
				if (_buttonRef == null)
				{
					_buttonRef = (CHandle<CallActionWidgetController>) CR2WTypeManager.Create("handle:CallActionWidgetController", "buttonRef", cr2w, this);
				}
				return _buttonRef;
			}
			set
			{
				if (_buttonRef == value)
				{
					return;
				}
				_buttonRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("state")] 
		public CEnum<IntercomStatus> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<IntercomStatus>) CR2WTypeManager.Create("IntercomStatus", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("onUpdateStatusListener")] 
		public CUInt32 OnUpdateStatusListener
		{
			get
			{
				if (_onUpdateStatusListener == null)
				{
					_onUpdateStatusListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onUpdateStatusListener", cr2w, this);
				}
				return _onUpdateStatusListener;
			}
			set
			{
				if (_onUpdateStatusListener == value)
				{
					return;
				}
				_onUpdateStatusListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		public IntercomInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

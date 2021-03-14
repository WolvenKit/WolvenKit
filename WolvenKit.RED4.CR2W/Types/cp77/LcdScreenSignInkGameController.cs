using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenSignInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;
		private CUInt32 _onGlitchingStateChangedListener;
		private CUInt32 _onMessegeChangedListener;

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		public LcdScreenSignInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioCommonEntitySettings : CVariable
	{
		private CName _onAttachEvent;
		private CName _onDetachEvent;
		private CBool _stopAllSoundsOnDetach;

		[Ordinal(0)] 
		[RED("onAttachEvent")] 
		public CName OnAttachEvent
		{
			get
			{
				if (_onAttachEvent == null)
				{
					_onAttachEvent = (CName) CR2WTypeManager.Create("CName", "onAttachEvent", cr2w, this);
				}
				return _onAttachEvent;
			}
			set
			{
				if (_onAttachEvent == value)
				{
					return;
				}
				_onAttachEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onDetachEvent")] 
		public CName OnDetachEvent
		{
			get
			{
				if (_onDetachEvent == null)
				{
					_onDetachEvent = (CName) CR2WTypeManager.Create("CName", "onDetachEvent", cr2w, this);
				}
				return _onDetachEvent;
			}
			set
			{
				if (_onDetachEvent == value)
				{
					return;
				}
				_onDetachEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stopAllSoundsOnDetach")] 
		public CBool StopAllSoundsOnDetach
		{
			get
			{
				if (_stopAllSoundsOnDetach == null)
				{
					_stopAllSoundsOnDetach = (CBool) CR2WTypeManager.Create("Bool", "stopAllSoundsOnDetach", cr2w, this);
				}
				return _stopAllSoundsOnDetach;
			}
			set
			{
				if (_stopAllSoundsOnDetach == value)
				{
					return;
				}
				_stopAllSoundsOnDetach = value;
				PropertySet(this);
			}
		}

		public audioCommonEntitySettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

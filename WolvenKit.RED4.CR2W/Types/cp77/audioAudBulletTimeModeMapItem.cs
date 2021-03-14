using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudBulletTimeModeMapItem : audioAudioMetadata
	{
		private CName _enterEvent;
		private CName _exitEvent;
		private CName _timeModeRTPC;

		[Ordinal(1)] 
		[RED("enterEvent")] 
		public CName EnterEvent
		{
			get
			{
				if (_enterEvent == null)
				{
					_enterEvent = (CName) CR2WTypeManager.Create("CName", "enterEvent", cr2w, this);
				}
				return _enterEvent;
			}
			set
			{
				if (_enterEvent == value)
				{
					return;
				}
				_enterEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("exitEvent")] 
		public CName ExitEvent
		{
			get
			{
				if (_exitEvent == null)
				{
					_exitEvent = (CName) CR2WTypeManager.Create("CName", "exitEvent", cr2w, this);
				}
				return _exitEvent;
			}
			set
			{
				if (_exitEvent == value)
				{
					return;
				}
				_exitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("timeModeRTPC")] 
		public CName TimeModeRTPC
		{
			get
			{
				if (_timeModeRTPC == null)
				{
					_timeModeRTPC = (CName) CR2WTypeManager.Create("CName", "timeModeRTPC", cr2w, this);
				}
				return _timeModeRTPC;
			}
			set
			{
				if (_timeModeRTPC == value)
				{
					return;
				}
				_timeModeRTPC = value;
				PropertySet(this);
			}
		}

		public audioAudBulletTimeModeMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

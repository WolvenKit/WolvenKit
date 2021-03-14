using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMusicController : CVariable
	{
		private CName _playEvent;
		private CName _stopEvent;
		private CName _muteEvent;
		private CName _unmuteEvent;

		[Ordinal(0)] 
		[RED("playEvent")] 
		public CName PlayEvent
		{
			get
			{
				if (_playEvent == null)
				{
					_playEvent = (CName) CR2WTypeManager.Create("CName", "playEvent", cr2w, this);
				}
				return _playEvent;
			}
			set
			{
				if (_playEvent == value)
				{
					return;
				}
				_playEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stopEvent")] 
		public CName StopEvent
		{
			get
			{
				if (_stopEvent == null)
				{
					_stopEvent = (CName) CR2WTypeManager.Create("CName", "stopEvent", cr2w, this);
				}
				return _stopEvent;
			}
			set
			{
				if (_stopEvent == value)
				{
					return;
				}
				_stopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("muteEvent")] 
		public CName MuteEvent
		{
			get
			{
				if (_muteEvent == null)
				{
					_muteEvent = (CName) CR2WTypeManager.Create("CName", "muteEvent", cr2w, this);
				}
				return _muteEvent;
			}
			set
			{
				if (_muteEvent == value)
				{
					return;
				}
				_muteEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("unmuteEvent")] 
		public CName UnmuteEvent
		{
			get
			{
				if (_unmuteEvent == null)
				{
					_unmuteEvent = (CName) CR2WTypeManager.Create("CName", "unmuteEvent", cr2w, this);
				}
				return _unmuteEvent;
			}
			set
			{
				if (_unmuteEvent == value)
				{
					return;
				}
				_unmuteEvent = value;
				PropertySet(this);
			}
		}

		public audioMusicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLoopingSoundController : CVariable
	{
		private CName _playEvent;
		private CName _preStopEvent;
		private CName _stopEvent;

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
		[RED("preStopEvent")] 
		public CName PreStopEvent
		{
			get
			{
				if (_preStopEvent == null)
				{
					_preStopEvent = (CName) CR2WTypeManager.Create("CName", "preStopEvent", cr2w, this);
				}
				return _preStopEvent;
			}
			set
			{
				if (_preStopEvent == value)
				{
					return;
				}
				_preStopEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public audioLoopingSoundController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioElevatorSettings : audioEntitySettings
	{
		private audioMusicController _musicEvents;
		private audioLoopingSoundController _movementEvents;
		private CName _callingEvent;
		private CName _destinationReachedEvent;
		private CName _panelSelectionEvent;

		[Ordinal(6)] 
		[RED("musicEvents")] 
		public audioMusicController MusicEvents
		{
			get
			{
				if (_musicEvents == null)
				{
					_musicEvents = (audioMusicController) CR2WTypeManager.Create("audioMusicController", "musicEvents", cr2w, this);
				}
				return _musicEvents;
			}
			set
			{
				if (_musicEvents == value)
				{
					return;
				}
				_musicEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("movementEvents")] 
		public audioLoopingSoundController MovementEvents
		{
			get
			{
				if (_movementEvents == null)
				{
					_movementEvents = (audioLoopingSoundController) CR2WTypeManager.Create("audioLoopingSoundController", "movementEvents", cr2w, this);
				}
				return _movementEvents;
			}
			set
			{
				if (_movementEvents == value)
				{
					return;
				}
				_movementEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("callingEvent")] 
		public CName CallingEvent
		{
			get
			{
				if (_callingEvent == null)
				{
					_callingEvent = (CName) CR2WTypeManager.Create("CName", "callingEvent", cr2w, this);
				}
				return _callingEvent;
			}
			set
			{
				if (_callingEvent == value)
				{
					return;
				}
				_callingEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("destinationReachedEvent")] 
		public CName DestinationReachedEvent
		{
			get
			{
				if (_destinationReachedEvent == null)
				{
					_destinationReachedEvent = (CName) CR2WTypeManager.Create("CName", "destinationReachedEvent", cr2w, this);
				}
				return _destinationReachedEvent;
			}
			set
			{
				if (_destinationReachedEvent == value)
				{
					return;
				}
				_destinationReachedEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("panelSelectionEvent")] 
		public CName PanelSelectionEvent
		{
			get
			{
				if (_panelSelectionEvent == null)
				{
					_panelSelectionEvent = (CName) CR2WTypeManager.Create("CName", "panelSelectionEvent", cr2w, this);
				}
				return _panelSelectionEvent;
			}
			set
			{
				if (_panelSelectionEvent == value)
				{
					return;
				}
				_panelSelectionEvent = value;
				PropertySet(this);
			}
		}

		public audioElevatorSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

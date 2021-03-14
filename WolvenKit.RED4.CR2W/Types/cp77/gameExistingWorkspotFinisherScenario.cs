using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameExistingWorkspotFinisherScenario : gameIFinisherScenario
	{
		private raRef<workWorkspotResource> _playerWorkspot;
		private CName _syncAnimSlotName;
		private CFloat _playbackDelay;
		private CFloat _blendTime;

		[Ordinal(0)] 
		[RED("playerWorkspot")] 
		public raRef<workWorkspotResource> PlayerWorkspot
		{
			get
			{
				if (_playerWorkspot == null)
				{
					_playerWorkspot = (raRef<workWorkspotResource>) CR2WTypeManager.Create("raRef:workWorkspotResource", "playerWorkspot", cr2w, this);
				}
				return _playerWorkspot;
			}
			set
			{
				if (_playerWorkspot == value)
				{
					return;
				}
				_playerWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get
			{
				if (_syncAnimSlotName == null)
				{
					_syncAnimSlotName = (CName) CR2WTypeManager.Create("CName", "syncAnimSlotName", cr2w, this);
				}
				return _syncAnimSlotName;
			}
			set
			{
				if (_syncAnimSlotName == value)
				{
					return;
				}
				_syncAnimSlotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playbackDelay")] 
		public CFloat PlaybackDelay
		{
			get
			{
				if (_playbackDelay == null)
				{
					_playbackDelay = (CFloat) CR2WTypeManager.Create("Float", "playbackDelay", cr2w, this);
				}
				return _playbackDelay;
			}
			set
			{
				if (_playbackDelay == value)
				{
					return;
				}
				_playbackDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		public gameExistingWorkspotFinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

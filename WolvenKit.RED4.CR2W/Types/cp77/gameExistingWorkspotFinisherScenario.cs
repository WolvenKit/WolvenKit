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
			get => GetProperty(ref _playerWorkspot);
			set => SetProperty(ref _playerWorkspot, value);
		}

		[Ordinal(1)] 
		[RED("syncAnimSlotName")] 
		public CName SyncAnimSlotName
		{
			get => GetProperty(ref _syncAnimSlotName);
			set => SetProperty(ref _syncAnimSlotName, value);
		}

		[Ordinal(2)] 
		[RED("playbackDelay")] 
		public CFloat PlaybackDelay
		{
			get => GetProperty(ref _playbackDelay);
			set => SetProperty(ref _playbackDelay, value);
		}

		[Ordinal(3)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		public gameExistingWorkspotFinisherScenario(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioSwitchNodeType : questIAudioNodeType
	{
		private audioAudSwitch _switch;
		private CBool _isMusic;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

		[Ordinal(0)] 
		[RED("switch")] 
		public audioAudSwitch Switch
		{
			get => GetProperty(ref _switch);
			set => SetProperty(ref _switch, value);
		}

		[Ordinal(1)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetProperty(ref _isMusic);
			set => SetProperty(ref _isMusic, value);
		}

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(3)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}
	}
}

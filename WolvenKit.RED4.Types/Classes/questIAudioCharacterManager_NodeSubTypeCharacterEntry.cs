using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIAudioCharacterManager_NodeSubTypeCharacterEntry : RedBaseClass
	{
		private gameEntityReference _puppetRef;
		private CBool _isPlayer;
		private CBool _enableSubSystem;

		[Ordinal(0)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(1)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(2)] 
		[RED("enableSubSystem")] 
		public CBool EnableSubSystem
		{
			get => GetProperty(ref _enableSubSystem);
			set => SetProperty(ref _enableSubSystem, value);
		}
	}
}

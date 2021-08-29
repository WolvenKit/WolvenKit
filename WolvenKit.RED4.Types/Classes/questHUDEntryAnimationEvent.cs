using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHUDEntryAnimationEvent : RedBaseClass
	{
		private CName _hudEntry;
		private CName _animationName;
		private CBool _dependsOnTimeDilation;

		[Ordinal(0)] 
		[RED("hudEntry")] 
		public CName HudEntry
		{
			get => GetProperty(ref _hudEntry);
			set => SetProperty(ref _hudEntry, value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(2)] 
		[RED("dependsOnTimeDilation")] 
		public CBool DependsOnTimeDilation
		{
			get => GetProperty(ref _dependsOnTimeDilation);
			set => SetProperty(ref _dependsOnTimeDilation, value);
		}
	}
}

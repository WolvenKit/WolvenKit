using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameAttachedEvent : redEvent
	{
		private CBool _isGameplayRelevant;
		private CString _displayName;
		private TweakDBID _contentScale;

		[Ordinal(0)] 
		[RED("isGameplayRelevant")] 
		public CBool IsGameplayRelevant
		{
			get => GetProperty(ref _isGameplayRelevant);
			set => SetProperty(ref _isGameplayRelevant, value);
		}

		[Ordinal(1)] 
		[RED("displayName")] 
		public CString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(2)] 
		[RED("contentScale")] 
		public TweakDBID ContentScale
		{
			get => GetProperty(ref _contentScale);
			set => SetProperty(ref _contentScale, value);
		}
	}
}

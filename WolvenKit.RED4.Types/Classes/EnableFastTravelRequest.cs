using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EnableFastTravelRequest : gameScriptableSystemRequest
	{
		private CBool _isEnabled;
		private CBool _forceRefreshUI;
		private CName _reason;
		private TweakDBID _linkedStatusEffectID;

		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(1)] 
		[RED("forceRefreshUI")] 
		public CBool ForceRefreshUI
		{
			get => GetProperty(ref _forceRefreshUI);
			set => SetProperty(ref _forceRefreshUI, value);
		}

		[Ordinal(2)] 
		[RED("reason")] 
		public CName Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(3)] 
		[RED("linkedStatusEffectID")] 
		public TweakDBID LinkedStatusEffectID
		{
			get => GetProperty(ref _linkedStatusEffectID);
			set => SetProperty(ref _linkedStatusEffectID, value);
		}
	}
}

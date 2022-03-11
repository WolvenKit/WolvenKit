
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionChangeCoverSelectionPreset_Record
	{
		[RED("changeThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat ChangeThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("coverDisablingDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat CoverDisablingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("fallbackToLastSelectedPreset")]
		[REDProperty(IsIgnored = true)]
		public CBool FallbackToLastSelectedPreset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("gatheringObjectCenter")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID GatheringObjectCenter
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("initialPreset")]
		[REDProperty(IsIgnored = true)]
		public CName InitialPreset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("preset")]
		[REDProperty(IsIgnored = true)]
		public CName Preset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}

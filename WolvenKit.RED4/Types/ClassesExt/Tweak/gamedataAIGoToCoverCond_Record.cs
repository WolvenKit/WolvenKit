
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIGoToCoverCond_Record
	{
		[RED("cover")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Cover
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("desiredCover")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID DesiredCover
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("desiredCoverChanged")]
		[REDProperty(IsIgnored = true)]
		public CInt32 DesiredCoverChanged
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isCoverSelected")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsCoverSelected
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("isEnteringOrLeavingCover")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsEnteringOrLeavingCover
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

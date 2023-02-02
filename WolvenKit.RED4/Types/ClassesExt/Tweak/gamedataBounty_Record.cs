
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBounty_Record
	{
		[RED("bountySetter")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BountySetter
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("drawWeight")]
		[REDProperty(IsIgnored = true)]
		public CFloat DrawWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("reward")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Reward
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("transgressions")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> Transgressions
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("visualTagsFilter")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> VisualTagsFilter
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("wantedStars")]
		[REDProperty(IsIgnored = true)]
		public CInt32 WantedStars
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}

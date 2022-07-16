
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIWeakSpotCond_Record
	{
		[RED("includeDestroyed")]
		[REDProperty(IsIgnored = true)]
		public CBool IncludeDestroyed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("weakspot")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Weakspot
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

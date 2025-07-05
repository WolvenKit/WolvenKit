
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionFailIfFriendlyFire_Record
	{
		[RED("checkOnlyFirstFrame")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckOnlyFirstFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
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

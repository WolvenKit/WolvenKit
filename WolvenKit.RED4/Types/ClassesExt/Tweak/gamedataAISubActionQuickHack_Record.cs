
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionQuickHack_Record
	{
		[RED("actionResult")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ActionResult
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("establishContactOnly")]
		[REDProperty(IsIgnored = true)]
		public CBool EstablishContactOnly
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

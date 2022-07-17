
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAITresspassingCond_Record
	{
		[RED("checkSafeArea")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckSafeArea
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

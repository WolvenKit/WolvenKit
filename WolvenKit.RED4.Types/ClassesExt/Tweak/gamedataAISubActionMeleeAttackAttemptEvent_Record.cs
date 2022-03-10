
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionMeleeAttackAttemptEvent_Record
	{
		[RED("isWindUp")]
		[REDProperty(IsIgnored = true)]
		public CBool IsWindUp
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

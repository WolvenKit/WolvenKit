
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPassiveProficiencyBonus_Record
	{
		[RED("effectorToTrigger")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EffectorToTrigger
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("statGroup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatGroup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("uiData")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID UiData
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

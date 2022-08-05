
namespace WolvenKit.RED4.Types
{
	public partial class gamedataContentAssignment_Record
	{
		[RED("powerLevelMod")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PowerLevelMod
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("questType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID QuestType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

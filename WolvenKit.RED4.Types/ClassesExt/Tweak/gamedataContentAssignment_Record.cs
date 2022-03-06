
namespace WolvenKit.RED4.Types
{
	public partial class gamedataContentAssignment_Record
	{
		[RED("overrideValue")]
		[REDProperty(IsIgnored = true)]
		public CInt32 OverrideValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
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
		
		[RED("upToCheck")]
		[REDProperty(IsIgnored = true)]
		public CBool UpToCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}


namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionPlayVoiceOver_Record
	{
		[RED("condition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Condition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cooldown")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Cooldown
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("repeat")]
		[REDProperty(IsIgnored = true)]
		public CBool Repeat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("sendEventToSquadmates")]
		[REDProperty(IsIgnored = true)]
		public CBool SendEventToSquadmates
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("setSelfAsAnsweringEntity")]
		[REDProperty(IsIgnored = true)]
		public CBool SetSelfAsAnsweringEntity
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

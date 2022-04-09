using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealQuestTargetEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("durationType")] 
		public CEnum<ERevealDurationType> DurationType
		{
			get => GetPropertyValue<CEnum<ERevealDurationType>>();
			set => SetPropertyValue<CEnum<ERevealDurationType>>(value);
		}

		[Ordinal(2)] 
		[RED("reveal")] 
		public CBool Reveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RevealQuestTargetEvent()
		{
			Reveal = true;
			Timeout = 4.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

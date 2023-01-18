using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] 
		[RED("isNewApplication")] 
		public CBool IsNewApplication
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(4)] 
		[RED("isAppliedOnSpawn")] 
		public CBool IsAppliedOnSpawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameeventsApplyStatusEffectEvent()
		{
			InstigatorEntityID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

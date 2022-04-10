using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleQuestUIEffectEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("glitch")] 
		public CBool Glitch
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("panamVehicleStartup")] 
		public CBool PanamVehicleStartup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("panamScreenType1")] 
		public CBool PanamScreenType1
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("panamScreenType2")] 
		public CBool PanamScreenType2
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("panamScreenType3")] 
		public CBool PanamScreenType3
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("panamScreenType4")] 
		public CBool PanamScreenType4
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleQuestUIEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

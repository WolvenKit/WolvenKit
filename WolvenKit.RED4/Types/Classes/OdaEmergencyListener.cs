using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OdaEmergencyListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("healNumber")] 
		public CInt32 HealNumber
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("heal1HealthPercentage")] 
		public CFloat Heal1HealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("heal2HealthPercentage")] 
		public CFloat Heal2HealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("heal3HealthPercentage")] 
		public CFloat Heal3HealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("heal4HealthPercentage")] 
		public CFloat Heal4HealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("heal5HealthPercentage")] 
		public CFloat Heal5HealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OdaEmergencyListener()
		{
			Heal1HealthPercentage = 70.000000F;
			Heal2HealthPercentage = 55.000000F;
			Heal3HealthPercentage = 40.000000F;
			Heal4HealthPercentage = 25.000000F;
			Heal5HealthPercentage = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

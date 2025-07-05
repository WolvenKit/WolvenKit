using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiPlayerBioMonitor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("currentCyberwarePct")] 
		public CInt32 CurrentCyberwarePct
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiPlayerBioMonitor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

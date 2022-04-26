using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltipData_QuickhackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("memorycost")] 
		public CInt32 Memorycost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("baseCost")] 
		public CInt32 BaseCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("uploadTime")] 
		public CFloat UploadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("attackEffects")] 
		public CArray<CHandle<DamageEffectUIEntry>> AttackEffects
		{
			get => GetPropertyValue<CArray<CHandle<DamageEffectUIEntry>>>();
			set => SetPropertyValue<CArray<CHandle<DamageEffectUIEntry>>>(value);
		}

		[Ordinal(6)] 
		[RED("uploadTimeDiff")] 
		public CFloat UploadTimeDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("durationDiff")] 
		public CFloat DurationDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("cooldownDiff")] 
		public CFloat CooldownDiff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public InventoryTooltipData_QuickhackData()
		{
			AttackEffects = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

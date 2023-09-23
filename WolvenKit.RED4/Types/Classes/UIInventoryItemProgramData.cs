using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemProgramData : IScriptable
	{
		[Ordinal(0)] 
		[RED("MemoryCost")] 
		public CInt32 MemoryCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("BaseCost")] 
		public CInt32 BaseCost
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("UploadTime")] 
		public CFloat UploadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("Duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("Cooldown")] 
		public CFloat Cooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("AttackEffects")] 
		public CArray<CHandle<DamageEffectUIEntry>> AttackEffects
		{
			get => GetPropertyValue<CArray<CHandle<DamageEffectUIEntry>>>();
			set => SetPropertyValue<CArray<CHandle<DamageEffectUIEntry>>>(value);
		}

		public UIInventoryItemProgramData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

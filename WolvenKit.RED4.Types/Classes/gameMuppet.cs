using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppet : gamePuppetBase
	{
		[Ordinal(40)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(41)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetPropertyValue<CHandle<entSlotComponent>>();
			set => SetPropertyValue<CHandle<entSlotComponent>>(value);
		}

		[Ordinal(42)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(45)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}

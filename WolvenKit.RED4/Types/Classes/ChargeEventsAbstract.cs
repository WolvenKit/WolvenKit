using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class ChargeEventsAbstract : WeaponEventsTransition
	{
		[Ordinal(5)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public ChargeEventsAbstract()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

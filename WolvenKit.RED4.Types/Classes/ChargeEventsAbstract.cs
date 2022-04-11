using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeEventsAbstract : WeaponEventsTransition
	{
		[Ordinal(3)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}

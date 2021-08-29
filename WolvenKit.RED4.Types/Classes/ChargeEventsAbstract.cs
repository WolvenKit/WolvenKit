using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ChargeEventsAbstract : WeaponEventsTransition
	{
		private CUInt32 _layerId;

		[Ordinal(3)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get => GetProperty(ref _layerId);
			set => SetProperty(ref _layerId, value);
		}
	}
}

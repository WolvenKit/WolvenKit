using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animMotionTableProvider_MasterSlaveBlend : animIMotionTableProvider
	{
		[Ordinal(5)] 
		[RED("masterInputIdx")] 
		public CUInt8 MasterInputIdx
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public animMotionTableProvider_MasterSlaveBlend()
		{
			Id = -1;
			ParentId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

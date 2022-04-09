using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidFacialAnimSetSRRefId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnRidFacialAnimSetSRRefId()
		{
			Id = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

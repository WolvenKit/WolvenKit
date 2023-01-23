using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnNodeId : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public scnNodeId()
		{
			Id = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOutputSocketStamp : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CUInt16 Name
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(1)] 
		[RED("ordinal")] 
		public CUInt16 Ordinal
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public scnOutputSocketStamp()
		{
			Name = 65535;
			Ordinal = 65535;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

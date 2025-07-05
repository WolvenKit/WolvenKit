using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnInputSocketStamp : RedBaseClass
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

		public scnInputSocketStamp()
		{
			Name = ushort.MaxValue;
			Ordinal = ushort.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

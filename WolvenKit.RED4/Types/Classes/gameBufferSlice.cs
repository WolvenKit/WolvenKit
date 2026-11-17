using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameBufferSlice : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("offset")] 
		public CUInt32 Offset
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(1)] 
		[RED("combined")] 
		public CUInt32 Combined
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameBufferSlice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

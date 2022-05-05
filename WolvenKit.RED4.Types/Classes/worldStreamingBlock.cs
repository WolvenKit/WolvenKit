using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldStreamingBlock : CResource
	{
		[Ordinal(1)] 
		[RED("descriptors")] 
		public CArray<worldStreamingSectorDescriptor> Descriptors
		{
			get => GetPropertyValue<CArray<worldStreamingSectorDescriptor>>();
			set => SetPropertyValue<CArray<worldStreamingSectorDescriptor>>(value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CUInt32 Index
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public worldStreamingBlock()
		{
			Descriptors = new();
			Index = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

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
		public worldStreamingBlockIndex Index
		{
			get => GetPropertyValue<worldStreamingBlockIndex>();
			set => SetPropertyValue<worldStreamingBlockIndex>(value);
		}

		public worldStreamingBlock()
		{
			Descriptors = new();
			Index = new worldStreamingBlockIndex();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceCookedAppearanceData : CResource
	{
		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<CResource>> Dependencies
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		[Ordinal(2)] 
		[RED("totalSizeOnDisk")] 
		public CUInt32 TotalSizeOnDisk
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public appearanceCookedAppearanceData()
		{
			Dependencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceCookedAppearanceData : CResource
	{
		private CArray<CResourceReference<CResource>> _dependencies;
		private CUInt32 _totalSizeOnDisk;

		[Ordinal(1)] 
		[RED("dependencies")] 
		public CArray<CResourceReference<CResource>> Dependencies
		{
			get => GetProperty(ref _dependencies);
			set => SetProperty(ref _dependencies, value);
		}

		[Ordinal(2)] 
		[RED("totalSizeOnDisk")] 
		public CUInt32 TotalSizeOnDisk
		{
			get => GetProperty(ref _totalSizeOnDisk);
			set => SetProperty(ref _totalSizeOnDisk, value);
		}
	}
}

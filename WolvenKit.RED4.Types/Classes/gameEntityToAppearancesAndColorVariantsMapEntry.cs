using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEntityToAppearancesAndColorVariantsMapEntry : ISerializable
	{
		private CUInt64 _entityPathHash;
		private CString _debugEntityPath;
		private CArray<gameEntityAppearanceColorVariantsArray> _appearancesAndTheirColorVariants;

		[Ordinal(0)] 
		[RED("entityPathHash")] 
		public CUInt64 EntityPathHash
		{
			get => GetProperty(ref _entityPathHash);
			set => SetProperty(ref _entityPathHash, value);
		}

		[Ordinal(1)] 
		[RED("debugEntityPath")] 
		public CString DebugEntityPath
		{
			get => GetProperty(ref _debugEntityPath);
			set => SetProperty(ref _debugEntityPath, value);
		}

		[Ordinal(2)] 
		[RED("appearancesAndTheirColorVariants")] 
		public CArray<gameEntityAppearanceColorVariantsArray> AppearancesAndTheirColorVariants
		{
			get => GetProperty(ref _appearancesAndTheirColorVariants);
			set => SetProperty(ref _appearancesAndTheirColorVariants, value);
		}
	}
}

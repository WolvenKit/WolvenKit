using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animImportFacialInitialControlsDesc : RedBaseClass
	{
		private CArray<CUInt16> _transformIds;
		private CArray<CName> _transformNames;
		private CArray<CUInt8> _transformRegions;

		[Ordinal(0)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get => GetProperty(ref _transformIds);
			set => SetProperty(ref _transformIds, value);
		}

		[Ordinal(1)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get => GetProperty(ref _transformNames);
			set => SetProperty(ref _transformNames, value);
		}

		[Ordinal(2)] 
		[RED("transformRegions")] 
		public CArray<CUInt8> TransformRegions
		{
			get => GetProperty(ref _transformRegions);
			set => SetProperty(ref _transformRegions, value);
		}
	}
}

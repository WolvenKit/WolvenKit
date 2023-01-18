using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialInitialControlsDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("transformIds")] 
		public CArray<CUInt16> TransformIds
		{
			get => GetPropertyValue<CArray<CUInt16>>();
			set => SetPropertyValue<CArray<CUInt16>>(value);
		}

		[Ordinal(1)] 
		[RED("transformNames")] 
		public CArray<CName> TransformNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("transformRegions")] 
		public CArray<CUInt8> TransformRegions
		{
			get => GetPropertyValue<CArray<CUInt8>>();
			set => SetPropertyValue<CArray<CUInt8>>(value);
		}

		public animImportFacialInitialControlsDesc()
		{
			TransformIds = new();
			TransformNames = new();
			TransformRegions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

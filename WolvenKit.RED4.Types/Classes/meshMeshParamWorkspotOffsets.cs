using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamWorkspotOffsets : meshMeshParameter
	{
		private CArray<CName> _names;
		private CArray<CMatrix> _offsets;

		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetProperty(ref _names);
			set => SetProperty(ref _names, value);
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CMatrix> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}
	}
}

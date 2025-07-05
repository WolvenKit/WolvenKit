using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamWorkspotOffsets : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("names")] 
		public CArray<CName> Names
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("offsets")] 
		public CArray<CMatrix> Offsets
		{
			get => GetPropertyValue<CArray<CMatrix>>();
			set => SetPropertyValue<CArray<CMatrix>>(value);
		}

		public meshMeshParamWorkspotOffsets()
		{
			Names = new();
			Offsets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

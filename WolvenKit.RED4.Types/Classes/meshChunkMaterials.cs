using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshChunkMaterials : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("materialNames")] 
		public CArray<CName> MaterialNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public meshChunkMaterials()
		{
			MaterialNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

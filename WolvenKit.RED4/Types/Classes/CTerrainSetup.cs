using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CTerrainSetup : CResource
	{
		[Ordinal(1)] 
		[RED("tiling")] 
		public CArray<CFloat> Tiling
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("physicalMaterial")] 
		public CArray<CName> PhysicalMaterial
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public CTerrainSetup()
		{
			Tiling = new();
			PhysicalMaterial = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

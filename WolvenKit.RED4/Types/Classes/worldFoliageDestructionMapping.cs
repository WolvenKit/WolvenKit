using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldFoliageDestructionMapping : ISerializable
	{
		[Ordinal(0)] 
		[RED("baseMesh")] 
		public CResourceAsyncReference<CMesh> BaseMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(1)] 
		[RED("destructibleMesh")] 
		public CResourceAsyncReference<CMesh> DestructibleMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		public worldFoliageDestructionMapping()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

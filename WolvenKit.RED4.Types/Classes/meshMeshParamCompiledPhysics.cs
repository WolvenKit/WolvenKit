using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class meshMeshParamCompiledPhysics : meshMeshParameter
	{
		[Ordinal(0)] 
		[RED("collection")] 
		public CHandle<physicsDeferredCollection> Collection
		{
			get => GetPropertyValue<CHandle<physicsDeferredCollection>>();
			set => SetPropertyValue<CHandle<physicsDeferredCollection>>(value);
		}

		public meshMeshParamCompiledPhysics()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class meshMeshParamCompiledPhysics : meshMeshParameter
	{
		private CHandle<physicsDeferredCollection> _collection;

		[Ordinal(0)] 
		[RED("collection")] 
		public CHandle<physicsDeferredCollection> Collection
		{
			get => GetProperty(ref _collection);
			set => SetProperty(ref _collection, value);
		}
	}
}

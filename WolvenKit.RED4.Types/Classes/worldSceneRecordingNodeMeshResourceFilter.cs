using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldSceneRecordingNodeMeshResourceFilter : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("forceFilterIgnore")] 
		public CArray<CResourceAsyncReference<CMesh>> ForceFilterIgnore
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CMesh>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CMesh>>>(value);
		}

		[Ordinal(1)] 
		[RED("forceFilterMatch")] 
		public CArray<CResourceAsyncReference<CMesh>> ForceFilterMatch
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CMesh>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CMesh>>>(value);
		}

		public worldSceneRecordingNodeMeshResourceFilter()
		{
			ForceFilterIgnore = new();
			ForceFilterMatch = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

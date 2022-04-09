using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkWidgetLibraryResource : CResource
	{
		[Ordinal(1)] 
		[RED("libraryItems")] 
		public CArray<inkWidgetLibraryItem> LibraryItems
		{
			get => GetPropertyValue<CArray<inkWidgetLibraryItem>>();
			set => SetPropertyValue<CArray<inkWidgetLibraryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("externalLibraries")] 
		public CArray<CResourceReference<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetPropertyValue<CArray<CResourceReference<inkWidgetLibraryResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<inkWidgetLibraryResource>>>(value);
		}

		[Ordinal(3)] 
		[RED("animationLibraryResRef")] 
		public CResourceAsyncReference<inkanimAnimationLibraryResource> AnimationLibraryResRef
		{
			get => GetPropertyValue<CResourceAsyncReference<inkanimAnimationLibraryResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkanimAnimationLibraryResource>>(value);
		}

		[Ordinal(4)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get => GetPropertyValue<CArray<CHandle<inkanimSequence>>>();
			set => SetPropertyValue<CArray<CHandle<inkanimSequence>>>(value);
		}

		[Ordinal(5)] 
		[RED("rootDefinitionIndex")] 
		public CUInt32 RootDefinitionIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("externalDependenciesForInternalItems")] 
		public CArray<CResourceAsyncReference<CResource>> ExternalDependenciesForInternalItems
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(7)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get => GetPropertyValue<CEnum<inkETextureResolution>>();
			set => SetPropertyValue<CEnum<inkETextureResolution>>(value);
		}

		[Ordinal(8)] 
		[RED("version")] 
		public CEnum<inkWidgetResourceVersion> Version
		{
			get => GetPropertyValue<CEnum<inkWidgetResourceVersion>>();
			set => SetPropertyValue<CEnum<inkWidgetResourceVersion>>(value);
		}

		public inkWidgetLibraryResource()
		{
			LibraryItems = new();
			ExternalLibraries = new();
			Sequences = new();
			ExternalDependenciesForInternalItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

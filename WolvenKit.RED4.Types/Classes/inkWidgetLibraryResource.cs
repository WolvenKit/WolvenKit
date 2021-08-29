using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkWidgetLibraryResource : CResource
	{
		private CArray<inkWidgetLibraryItem> _libraryItems;
		private CArray<CResourceReference<inkWidgetLibraryResource>> _externalLibraries;
		private CResourceAsyncReference<inkanimAnimationLibraryResource> _animationLibraryResRef;
		private CArray<CHandle<inkanimSequence>> _sequences;
		private CUInt32 _rootDefinitionIndex;
		private CArray<CResourceAsyncReference<CResource>> _externalDependenciesForInternalItems;
		private CEnum<inkETextureResolution> _rootResolution;
		private CEnum<inkWidgetResourceVersion> _version;

		[Ordinal(1)] 
		[RED("libraryItems")] 
		public CArray<inkWidgetLibraryItem> LibraryItems
		{
			get => GetProperty(ref _libraryItems);
			set => SetProperty(ref _libraryItems, value);
		}

		[Ordinal(2)] 
		[RED("externalLibraries")] 
		public CArray<CResourceReference<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetProperty(ref _externalLibraries);
			set => SetProperty(ref _externalLibraries, value);
		}

		[Ordinal(3)] 
		[RED("animationLibraryResRef")] 
		public CResourceAsyncReference<inkanimAnimationLibraryResource> AnimationLibraryResRef
		{
			get => GetProperty(ref _animationLibraryResRef);
			set => SetProperty(ref _animationLibraryResRef, value);
		}

		[Ordinal(4)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get => GetProperty(ref _sequences);
			set => SetProperty(ref _sequences, value);
		}

		[Ordinal(5)] 
		[RED("rootDefinitionIndex")] 
		public CUInt32 RootDefinitionIndex
		{
			get => GetProperty(ref _rootDefinitionIndex);
			set => SetProperty(ref _rootDefinitionIndex, value);
		}

		[Ordinal(6)] 
		[RED("externalDependenciesForInternalItems")] 
		public CArray<CResourceAsyncReference<CResource>> ExternalDependenciesForInternalItems
		{
			get => GetProperty(ref _externalDependenciesForInternalItems);
			set => SetProperty(ref _externalDependenciesForInternalItems, value);
		}

		[Ordinal(7)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get => GetProperty(ref _rootResolution);
			set => SetProperty(ref _rootResolution, value);
		}

		[Ordinal(8)] 
		[RED("version")] 
		public CEnum<inkWidgetResourceVersion> Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}
	}
}

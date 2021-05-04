using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetLibraryResource : CResource
	{
		private CArray<inkWidgetLibraryItem> _libraryItems;
		private CArray<rRef<inkWidgetLibraryResource>> _externalLibraries;
		private raRef<inkanimAnimationLibraryResource> _animationLibraryResRef;
		private CArray<CHandle<inkanimSequence>> _sequences;
		private CUInt32 _rootDefinitionIndex;
		private CArray<raRef<CResource>> _externalDependenciesForInternalItems;
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
		public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries
		{
			get => GetProperty(ref _externalLibraries);
			set => SetProperty(ref _externalLibraries, value);
		}

		[Ordinal(3)] 
		[RED("animationLibraryResRef")] 
		public raRef<inkanimAnimationLibraryResource> AnimationLibraryResRef
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
		public CArray<raRef<CResource>> ExternalDependenciesForInternalItems
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

		public inkWidgetLibraryResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

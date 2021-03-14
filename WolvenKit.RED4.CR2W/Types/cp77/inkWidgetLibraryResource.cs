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
			get
			{
				if (_libraryItems == null)
				{
					_libraryItems = (CArray<inkWidgetLibraryItem>) CR2WTypeManager.Create("array:inkWidgetLibraryItem", "libraryItems", cr2w, this);
				}
				return _libraryItems;
			}
			set
			{
				if (_libraryItems == value)
				{
					return;
				}
				_libraryItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("externalLibraries")] 
		public CArray<rRef<inkWidgetLibraryResource>> ExternalLibraries
		{
			get
			{
				if (_externalLibraries == null)
				{
					_externalLibraries = (CArray<rRef<inkWidgetLibraryResource>>) CR2WTypeManager.Create("array:rRef:inkWidgetLibraryResource", "externalLibraries", cr2w, this);
				}
				return _externalLibraries;
			}
			set
			{
				if (_externalLibraries == value)
				{
					return;
				}
				_externalLibraries = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animationLibraryResRef")] 
		public raRef<inkanimAnimationLibraryResource> AnimationLibraryResRef
		{
			get
			{
				if (_animationLibraryResRef == null)
				{
					_animationLibraryResRef = (raRef<inkanimAnimationLibraryResource>) CR2WTypeManager.Create("raRef:inkanimAnimationLibraryResource", "animationLibraryResRef", cr2w, this);
				}
				return _animationLibraryResRef;
			}
			set
			{
				if (_animationLibraryResRef == value)
				{
					return;
				}
				_animationLibraryResRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("sequences")] 
		public CArray<CHandle<inkanimSequence>> Sequences
		{
			get
			{
				if (_sequences == null)
				{
					_sequences = (CArray<CHandle<inkanimSequence>>) CR2WTypeManager.Create("array:handle:inkanimSequence", "sequences", cr2w, this);
				}
				return _sequences;
			}
			set
			{
				if (_sequences == value)
				{
					return;
				}
				_sequences = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("rootDefinitionIndex")] 
		public CUInt32 RootDefinitionIndex
		{
			get
			{
				if (_rootDefinitionIndex == null)
				{
					_rootDefinitionIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "rootDefinitionIndex", cr2w, this);
				}
				return _rootDefinitionIndex;
			}
			set
			{
				if (_rootDefinitionIndex == value)
				{
					return;
				}
				_rootDefinitionIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("externalDependenciesForInternalItems")] 
		public CArray<raRef<CResource>> ExternalDependenciesForInternalItems
		{
			get
			{
				if (_externalDependenciesForInternalItems == null)
				{
					_externalDependenciesForInternalItems = (CArray<raRef<CResource>>) CR2WTypeManager.Create("array:raRef:CResource", "externalDependenciesForInternalItems", cr2w, this);
				}
				return _externalDependenciesForInternalItems;
			}
			set
			{
				if (_externalDependenciesForInternalItems == value)
				{
					return;
				}
				_externalDependenciesForInternalItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rootResolution")] 
		public CEnum<inkETextureResolution> RootResolution
		{
			get
			{
				if (_rootResolution == null)
				{
					_rootResolution = (CEnum<inkETextureResolution>) CR2WTypeManager.Create("inkETextureResolution", "rootResolution", cr2w, this);
				}
				return _rootResolution;
			}
			set
			{
				if (_rootResolution == value)
				{
					return;
				}
				_rootResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("version")] 
		public CEnum<inkWidgetResourceVersion> Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CEnum<inkWidgetResourceVersion>) CR2WTypeManager.Create("inkWidgetResourceVersion", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		public inkWidgetLibraryResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

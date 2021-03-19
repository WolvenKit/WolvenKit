using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSet : CResource
	{
		private CArray<CHandle<animAnimSetEntry>> _animations;
		private CArray<animAnimDataChunk> _animationDataChunks;
		private rRef<animRig> _rig;
		private redTagList _tags;
		private rRef<CResource> _correspondingArchetype;
		private CUInt32 _version;

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<CHandle<animAnimSetEntry>> Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(2)] 
		[RED("animationDataChunks")] 
		public CArray<animAnimDataChunk> AnimationDataChunks
		{
			get => GetProperty(ref _animationDataChunks);
			set => SetProperty(ref _animationDataChunks, value);
		}

		[Ordinal(3)] 
		[RED("rig")] 
		public rRef<animRig> Rig
		{
			get => GetProperty(ref _rig);
			set => SetProperty(ref _rig, value);
		}

		[Ordinal(4)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(5)] 
		[RED("correspondingArchetype")] 
		public rRef<CResource> CorrespondingArchetype
		{
			get => GetProperty(ref _correspondingArchetype);
			set => SetProperty(ref _correspondingArchetype, value);
		}

		[Ordinal(6)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public animAnimSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

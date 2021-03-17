using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSnapToTerrainIkRequest : CVariable
	{
		private CName _ikChain;
		private animTransformIndex _footTransformIndex;
		private animTransformIndex _poleVectorRefTransformIndex;
		private animNamedTrackIndex _enableFootLockFloatTrack;

		[Ordinal(0)] 
		[RED("ikChain")] 
		public CName IkChain
		{
			get => GetProperty(ref _ikChain);
			set => SetProperty(ref _ikChain, value);
		}

		[Ordinal(1)] 
		[RED("footTransformIndex")] 
		public animTransformIndex FootTransformIndex
		{
			get => GetProperty(ref _footTransformIndex);
			set => SetProperty(ref _footTransformIndex, value);
		}

		[Ordinal(2)] 
		[RED("poleVectorRefTransformIndex")] 
		public animTransformIndex PoleVectorRefTransformIndex
		{
			get => GetProperty(ref _poleVectorRefTransformIndex);
			set => SetProperty(ref _poleVectorRefTransformIndex, value);
		}

		[Ordinal(3)] 
		[RED("enableFootLockFloatTrack")] 
		public animNamedTrackIndex EnableFootLockFloatTrack
		{
			get => GetProperty(ref _enableFootLockFloatTrack);
			set => SetProperty(ref _enableFootLockFloatTrack, value);
		}

		public animSnapToTerrainIkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

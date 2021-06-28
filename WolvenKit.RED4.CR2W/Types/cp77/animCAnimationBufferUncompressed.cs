using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCAnimationBufferUncompressed : animIAnimationBuffer
	{
		private CArray<CArray<QsTransform>> _transforms;
		private CArray<CArray<CFloat>> _tracks;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<CArray<QsTransform>> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}

		[Ordinal(1)] 
		[RED("tracks")] 
		public CArray<CArray<CFloat>> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public animCAnimationBufferUncompressed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

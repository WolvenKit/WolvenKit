using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseLimitWeights : CVariable
	{
		private CFloat _min;
		private CFloat _mid;
		private CFloat _max;
		private CInt16 _poseTrackIndex;
		private CUInt8 _type;
		private CBool _isCachable;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("mid")] 
		public CFloat Mid
		{
			get => GetProperty(ref _mid);
			set => SetProperty(ref _mid, value);
		}

		[Ordinal(2)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(3)] 
		[RED("poseTrackIndex")] 
		public CInt16 PoseTrackIndex
		{
			get => GetProperty(ref _poseTrackIndex);
			set => SetProperty(ref _poseTrackIndex, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get => GetProperty(ref _isCachable);
			set => SetProperty(ref _isCachable, value);
		}

		public animPoseLimitWeights(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

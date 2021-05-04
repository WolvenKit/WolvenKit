using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animTwistOutput : CVariable
	{
		private CFloat _positiveScale;
		private CFloat _negativeScale;
		private CEnum<animAxis> _twistAxis;
		private animTransformIndex _twistedTransform;
		private animNamedTrackIndex _outputAngleTrack;

		[Ordinal(0)] 
		[RED("positiveScale")] 
		public CFloat PositiveScale
		{
			get => GetProperty(ref _positiveScale);
			set => SetProperty(ref _positiveScale, value);
		}

		[Ordinal(1)] 
		[RED("negativeScale")] 
		public CFloat NegativeScale
		{
			get => GetProperty(ref _negativeScale);
			set => SetProperty(ref _negativeScale, value);
		}

		[Ordinal(2)] 
		[RED("twistAxis")] 
		public CEnum<animAxis> TwistAxis
		{
			get => GetProperty(ref _twistAxis);
			set => SetProperty(ref _twistAxis, value);
		}

		[Ordinal(3)] 
		[RED("twistedTransform")] 
		public animTransformIndex TwistedTransform
		{
			get => GetProperty(ref _twistedTransform);
			set => SetProperty(ref _twistedTransform, value);
		}

		[Ordinal(4)] 
		[RED("outputAngleTrack")] 
		public animNamedTrackIndex OutputAngleTrack
		{
			get => GetProperty(ref _outputAngleTrack);
			set => SetProperty(ref _outputAngleTrack, value);
		}

		public animTwistOutput(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

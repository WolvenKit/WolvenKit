using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ConeLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _coneTransform;
		private animTransformIndex _constrainedTransform;
		private Vector3 _coneAxisLs;
		private Vector3 _coneAxisNormalizedLs;
		private Vector3 _coneOffsetMs;
		private animVectorLink _coneOffsetMsLink;
		private curveData<CFloat> _marginEaseOutCurve;
		private CFloat _limit1;
		private animFloatLink _limit1Link;
		private animNamedTrackIndex _limit1FloatTrack;
		private CFloat _paraboloidRadius1;
		private CFloat _limit2;
		private animFloatLink _limit2Link;
		private animNamedTrackIndex _limit2FloatTrack;
		private CFloat _paraboloidRadius2;
		private CFloat _limit3;
		private animFloatLink _limit3Link;
		private animNamedTrackIndex _limit3FloatTrack;
		private CFloat _paraboloidRadius3;
		private CFloat _limit4;
		private animFloatLink _limit4Link;
		private animNamedTrackIndex _limit4FloatTrack;
		private CFloat _paraboloidRadius4;
		private animNamedTrackIndex _coneLimitReached;
		private CBool _debug;
		private CBool _colorfulCone;
		private CBool _applyDebugConeScalling;

		[Ordinal(12)] 
		[RED("coneTransform")] 
		public animTransformIndex ConeTransform
		{
			get => GetProperty(ref _coneTransform);
			set => SetProperty(ref _coneTransform, value);
		}

		[Ordinal(13)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(14)] 
		[RED("coneAxisLs")] 
		public Vector3 ConeAxisLs
		{
			get => GetProperty(ref _coneAxisLs);
			set => SetProperty(ref _coneAxisLs, value);
		}

		[Ordinal(15)] 
		[RED("coneAxisNormalizedLs")] 
		public Vector3 ConeAxisNormalizedLs
		{
			get => GetProperty(ref _coneAxisNormalizedLs);
			set => SetProperty(ref _coneAxisNormalizedLs, value);
		}

		[Ordinal(16)] 
		[RED("coneOffsetMs")] 
		public Vector3 ConeOffsetMs
		{
			get => GetProperty(ref _coneOffsetMs);
			set => SetProperty(ref _coneOffsetMs, value);
		}

		[Ordinal(17)] 
		[RED("coneOffsetMsLink")] 
		public animVectorLink ConeOffsetMsLink
		{
			get => GetProperty(ref _coneOffsetMsLink);
			set => SetProperty(ref _coneOffsetMsLink, value);
		}

		[Ordinal(18)] 
		[RED("marginEaseOutCurve")] 
		public curveData<CFloat> MarginEaseOutCurve
		{
			get => GetProperty(ref _marginEaseOutCurve);
			set => SetProperty(ref _marginEaseOutCurve, value);
		}

		[Ordinal(19)] 
		[RED("limit1")] 
		public CFloat Limit1
		{
			get => GetProperty(ref _limit1);
			set => SetProperty(ref _limit1, value);
		}

		[Ordinal(20)] 
		[RED("limit1Link")] 
		public animFloatLink Limit1Link
		{
			get => GetProperty(ref _limit1Link);
			set => SetProperty(ref _limit1Link, value);
		}

		[Ordinal(21)] 
		[RED("limit1FloatTrack")] 
		public animNamedTrackIndex Limit1FloatTrack
		{
			get => GetProperty(ref _limit1FloatTrack);
			set => SetProperty(ref _limit1FloatTrack, value);
		}

		[Ordinal(22)] 
		[RED("paraboloidRadius1")] 
		public CFloat ParaboloidRadius1
		{
			get => GetProperty(ref _paraboloidRadius1);
			set => SetProperty(ref _paraboloidRadius1, value);
		}

		[Ordinal(23)] 
		[RED("limit2")] 
		public CFloat Limit2
		{
			get => GetProperty(ref _limit2);
			set => SetProperty(ref _limit2, value);
		}

		[Ordinal(24)] 
		[RED("limit2Link")] 
		public animFloatLink Limit2Link
		{
			get => GetProperty(ref _limit2Link);
			set => SetProperty(ref _limit2Link, value);
		}

		[Ordinal(25)] 
		[RED("limit2FloatTrack")] 
		public animNamedTrackIndex Limit2FloatTrack
		{
			get => GetProperty(ref _limit2FloatTrack);
			set => SetProperty(ref _limit2FloatTrack, value);
		}

		[Ordinal(26)] 
		[RED("paraboloidRadius2")] 
		public CFloat ParaboloidRadius2
		{
			get => GetProperty(ref _paraboloidRadius2);
			set => SetProperty(ref _paraboloidRadius2, value);
		}

		[Ordinal(27)] 
		[RED("limit3")] 
		public CFloat Limit3
		{
			get => GetProperty(ref _limit3);
			set => SetProperty(ref _limit3, value);
		}

		[Ordinal(28)] 
		[RED("limit3Link")] 
		public animFloatLink Limit3Link
		{
			get => GetProperty(ref _limit3Link);
			set => SetProperty(ref _limit3Link, value);
		}

		[Ordinal(29)] 
		[RED("limit3FloatTrack")] 
		public animNamedTrackIndex Limit3FloatTrack
		{
			get => GetProperty(ref _limit3FloatTrack);
			set => SetProperty(ref _limit3FloatTrack, value);
		}

		[Ordinal(30)] 
		[RED("paraboloidRadius3")] 
		public CFloat ParaboloidRadius3
		{
			get => GetProperty(ref _paraboloidRadius3);
			set => SetProperty(ref _paraboloidRadius3, value);
		}

		[Ordinal(31)] 
		[RED("limit4")] 
		public CFloat Limit4
		{
			get => GetProperty(ref _limit4);
			set => SetProperty(ref _limit4, value);
		}

		[Ordinal(32)] 
		[RED("limit4Link")] 
		public animFloatLink Limit4Link
		{
			get => GetProperty(ref _limit4Link);
			set => SetProperty(ref _limit4Link, value);
		}

		[Ordinal(33)] 
		[RED("limit4FloatTrack")] 
		public animNamedTrackIndex Limit4FloatTrack
		{
			get => GetProperty(ref _limit4FloatTrack);
			set => SetProperty(ref _limit4FloatTrack, value);
		}

		[Ordinal(34)] 
		[RED("paraboloidRadius4")] 
		public CFloat ParaboloidRadius4
		{
			get => GetProperty(ref _paraboloidRadius4);
			set => SetProperty(ref _paraboloidRadius4, value);
		}

		[Ordinal(35)] 
		[RED("coneLimitReached")] 
		public animNamedTrackIndex ConeLimitReached
		{
			get => GetProperty(ref _coneLimitReached);
			set => SetProperty(ref _coneLimitReached, value);
		}

		[Ordinal(36)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetProperty(ref _debug);
			set => SetProperty(ref _debug, value);
		}

		[Ordinal(37)] 
		[RED("colorfulCone")] 
		public CBool ColorfulCone
		{
			get => GetProperty(ref _colorfulCone);
			set => SetProperty(ref _colorfulCone, value);
		}

		[Ordinal(38)] 
		[RED("applyDebugConeScalling")] 
		public CBool ApplyDebugConeScalling
		{
			get => GetProperty(ref _applyDebugConeScalling);
			set => SetProperty(ref _applyDebugConeScalling, value);
		}

		public animAnimNode_ConeLimit(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

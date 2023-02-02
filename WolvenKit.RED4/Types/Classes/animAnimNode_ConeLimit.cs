using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ConeLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("coneTransform")] 
		public animTransformIndex ConeTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(13)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(14)] 
		[RED("coneAxisLs")] 
		public Vector3 ConeAxisLs
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(15)] 
		[RED("coneAxisNormalizedLs")] 
		public Vector3 ConeAxisNormalizedLs
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(16)] 
		[RED("coneOffsetMs")] 
		public Vector3 ConeOffsetMs
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(17)] 
		[RED("coneOffsetMsLink")] 
		public animVectorLink ConeOffsetMsLink
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		[Ordinal(18)] 
		[RED("marginEaseOutCurve")] 
		public CLegacySingleChannelCurve<CFloat> MarginEaseOutCurve
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(19)] 
		[RED("limit1")] 
		public CFloat Limit1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("limit1Link")] 
		public animFloatLink Limit1Link
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(21)] 
		[RED("limit1FloatTrack")] 
		public animNamedTrackIndex Limit1FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(22)] 
		[RED("paraboloidRadius1")] 
		public CFloat ParaboloidRadius1
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("limit2")] 
		public CFloat Limit2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("limit2Link")] 
		public animFloatLink Limit2Link
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(25)] 
		[RED("limit2FloatTrack")] 
		public animNamedTrackIndex Limit2FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(26)] 
		[RED("paraboloidRadius2")] 
		public CFloat ParaboloidRadius2
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("limit3")] 
		public CFloat Limit3
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("limit3Link")] 
		public animFloatLink Limit3Link
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(29)] 
		[RED("limit3FloatTrack")] 
		public animNamedTrackIndex Limit3FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(30)] 
		[RED("paraboloidRadius3")] 
		public CFloat ParaboloidRadius3
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("limit4")] 
		public CFloat Limit4
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("limit4Link")] 
		public animFloatLink Limit4Link
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		[Ordinal(33)] 
		[RED("limit4FloatTrack")] 
		public animNamedTrackIndex Limit4FloatTrack
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(34)] 
		[RED("paraboloidRadius4")] 
		public CFloat ParaboloidRadius4
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(35)] 
		[RED("coneLimitReached")] 
		public animNamedTrackIndex ConeLimitReached
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(36)] 
		[RED("debug")] 
		public CBool Debug
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("colorfulCone")] 
		public CBool ColorfulCone
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("applyDebugConeScalling")] 
		public CBool ApplyDebugConeScalling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_ConeLimit()
		{
			Id = 4294967295;
			InputLink = new();
			ConeTransform = new();
			ConstrainedTransform = new();
			ConeAxisLs = new() { Y = 1.000000F };
			ConeAxisNormalizedLs = new() { Y = 1.000000F };
			ConeOffsetMs = new();
			ConeOffsetMsLink = new();
			Limit1 = 45.000000F;
			Limit1Link = new();
			Limit1FloatTrack = new();
			ParaboloidRadius1 = 0.050000F;
			Limit2 = 45.000000F;
			Limit2Link = new();
			Limit2FloatTrack = new();
			ParaboloidRadius2 = 0.050000F;
			Limit3 = 45.000000F;
			Limit3Link = new();
			Limit3FloatTrack = new();
			ParaboloidRadius3 = 0.050000F;
			Limit4 = 45.000000F;
			Limit4Link = new();
			Limit4FloatTrack = new();
			ParaboloidRadius4 = 0.050000F;
			ConeLimitReached = new();
			ApplyDebugConeScalling = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

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
			get
			{
				if (_coneTransform == null)
				{
					_coneTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "coneTransform", cr2w, this);
				}
				return _coneTransform;
			}
			set
			{
				if (_coneTransform == value)
				{
					return;
				}
				_coneTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get
			{
				if (_constrainedTransform == null)
				{
					_constrainedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "constrainedTransform", cr2w, this);
				}
				return _constrainedTransform;
			}
			set
			{
				if (_constrainedTransform == value)
				{
					return;
				}
				_constrainedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("coneAxisLs")] 
		public Vector3 ConeAxisLs
		{
			get
			{
				if (_coneAxisLs == null)
				{
					_coneAxisLs = (Vector3) CR2WTypeManager.Create("Vector3", "coneAxisLs", cr2w, this);
				}
				return _coneAxisLs;
			}
			set
			{
				if (_coneAxisLs == value)
				{
					return;
				}
				_coneAxisLs = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("coneAxisNormalizedLs")] 
		public Vector3 ConeAxisNormalizedLs
		{
			get
			{
				if (_coneAxisNormalizedLs == null)
				{
					_coneAxisNormalizedLs = (Vector3) CR2WTypeManager.Create("Vector3", "coneAxisNormalizedLs", cr2w, this);
				}
				return _coneAxisNormalizedLs;
			}
			set
			{
				if (_coneAxisNormalizedLs == value)
				{
					return;
				}
				_coneAxisNormalizedLs = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("coneOffsetMs")] 
		public Vector3 ConeOffsetMs
		{
			get
			{
				if (_coneOffsetMs == null)
				{
					_coneOffsetMs = (Vector3) CR2WTypeManager.Create("Vector3", "coneOffsetMs", cr2w, this);
				}
				return _coneOffsetMs;
			}
			set
			{
				if (_coneOffsetMs == value)
				{
					return;
				}
				_coneOffsetMs = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("coneOffsetMsLink")] 
		public animVectorLink ConeOffsetMsLink
		{
			get
			{
				if (_coneOffsetMsLink == null)
				{
					_coneOffsetMsLink = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "coneOffsetMsLink", cr2w, this);
				}
				return _coneOffsetMsLink;
			}
			set
			{
				if (_coneOffsetMsLink == value)
				{
					return;
				}
				_coneOffsetMsLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("marginEaseOutCurve")] 
		public curveData<CFloat> MarginEaseOutCurve
		{
			get
			{
				if (_marginEaseOutCurve == null)
				{
					_marginEaseOutCurve = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "marginEaseOutCurve", cr2w, this);
				}
				return _marginEaseOutCurve;
			}
			set
			{
				if (_marginEaseOutCurve == value)
				{
					return;
				}
				_marginEaseOutCurve = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("limit1")] 
		public CFloat Limit1
		{
			get
			{
				if (_limit1 == null)
				{
					_limit1 = (CFloat) CR2WTypeManager.Create("Float", "limit1", cr2w, this);
				}
				return _limit1;
			}
			set
			{
				if (_limit1 == value)
				{
					return;
				}
				_limit1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("limit1Link")] 
		public animFloatLink Limit1Link
		{
			get
			{
				if (_limit1Link == null)
				{
					_limit1Link = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "limit1Link", cr2w, this);
				}
				return _limit1Link;
			}
			set
			{
				if (_limit1Link == value)
				{
					return;
				}
				_limit1Link = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("limit1FloatTrack")] 
		public animNamedTrackIndex Limit1FloatTrack
		{
			get
			{
				if (_limit1FloatTrack == null)
				{
					_limit1FloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "limit1FloatTrack", cr2w, this);
				}
				return _limit1FloatTrack;
			}
			set
			{
				if (_limit1FloatTrack == value)
				{
					return;
				}
				_limit1FloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("paraboloidRadius1")] 
		public CFloat ParaboloidRadius1
		{
			get
			{
				if (_paraboloidRadius1 == null)
				{
					_paraboloidRadius1 = (CFloat) CR2WTypeManager.Create("Float", "paraboloidRadius1", cr2w, this);
				}
				return _paraboloidRadius1;
			}
			set
			{
				if (_paraboloidRadius1 == value)
				{
					return;
				}
				_paraboloidRadius1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("limit2")] 
		public CFloat Limit2
		{
			get
			{
				if (_limit2 == null)
				{
					_limit2 = (CFloat) CR2WTypeManager.Create("Float", "limit2", cr2w, this);
				}
				return _limit2;
			}
			set
			{
				if (_limit2 == value)
				{
					return;
				}
				_limit2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("limit2Link")] 
		public animFloatLink Limit2Link
		{
			get
			{
				if (_limit2Link == null)
				{
					_limit2Link = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "limit2Link", cr2w, this);
				}
				return _limit2Link;
			}
			set
			{
				if (_limit2Link == value)
				{
					return;
				}
				_limit2Link = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("limit2FloatTrack")] 
		public animNamedTrackIndex Limit2FloatTrack
		{
			get
			{
				if (_limit2FloatTrack == null)
				{
					_limit2FloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "limit2FloatTrack", cr2w, this);
				}
				return _limit2FloatTrack;
			}
			set
			{
				if (_limit2FloatTrack == value)
				{
					return;
				}
				_limit2FloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("paraboloidRadius2")] 
		public CFloat ParaboloidRadius2
		{
			get
			{
				if (_paraboloidRadius2 == null)
				{
					_paraboloidRadius2 = (CFloat) CR2WTypeManager.Create("Float", "paraboloidRadius2", cr2w, this);
				}
				return _paraboloidRadius2;
			}
			set
			{
				if (_paraboloidRadius2 == value)
				{
					return;
				}
				_paraboloidRadius2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("limit3")] 
		public CFloat Limit3
		{
			get
			{
				if (_limit3 == null)
				{
					_limit3 = (CFloat) CR2WTypeManager.Create("Float", "limit3", cr2w, this);
				}
				return _limit3;
			}
			set
			{
				if (_limit3 == value)
				{
					return;
				}
				_limit3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("limit3Link")] 
		public animFloatLink Limit3Link
		{
			get
			{
				if (_limit3Link == null)
				{
					_limit3Link = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "limit3Link", cr2w, this);
				}
				return _limit3Link;
			}
			set
			{
				if (_limit3Link == value)
				{
					return;
				}
				_limit3Link = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("limit3FloatTrack")] 
		public animNamedTrackIndex Limit3FloatTrack
		{
			get
			{
				if (_limit3FloatTrack == null)
				{
					_limit3FloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "limit3FloatTrack", cr2w, this);
				}
				return _limit3FloatTrack;
			}
			set
			{
				if (_limit3FloatTrack == value)
				{
					return;
				}
				_limit3FloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("paraboloidRadius3")] 
		public CFloat ParaboloidRadius3
		{
			get
			{
				if (_paraboloidRadius3 == null)
				{
					_paraboloidRadius3 = (CFloat) CR2WTypeManager.Create("Float", "paraboloidRadius3", cr2w, this);
				}
				return _paraboloidRadius3;
			}
			set
			{
				if (_paraboloidRadius3 == value)
				{
					return;
				}
				_paraboloidRadius3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("limit4")] 
		public CFloat Limit4
		{
			get
			{
				if (_limit4 == null)
				{
					_limit4 = (CFloat) CR2WTypeManager.Create("Float", "limit4", cr2w, this);
				}
				return _limit4;
			}
			set
			{
				if (_limit4 == value)
				{
					return;
				}
				_limit4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("limit4Link")] 
		public animFloatLink Limit4Link
		{
			get
			{
				if (_limit4Link == null)
				{
					_limit4Link = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "limit4Link", cr2w, this);
				}
				return _limit4Link;
			}
			set
			{
				if (_limit4Link == value)
				{
					return;
				}
				_limit4Link = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("limit4FloatTrack")] 
		public animNamedTrackIndex Limit4FloatTrack
		{
			get
			{
				if (_limit4FloatTrack == null)
				{
					_limit4FloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "limit4FloatTrack", cr2w, this);
				}
				return _limit4FloatTrack;
			}
			set
			{
				if (_limit4FloatTrack == value)
				{
					return;
				}
				_limit4FloatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("paraboloidRadius4")] 
		public CFloat ParaboloidRadius4
		{
			get
			{
				if (_paraboloidRadius4 == null)
				{
					_paraboloidRadius4 = (CFloat) CR2WTypeManager.Create("Float", "paraboloidRadius4", cr2w, this);
				}
				return _paraboloidRadius4;
			}
			set
			{
				if (_paraboloidRadius4 == value)
				{
					return;
				}
				_paraboloidRadius4 = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("coneLimitReached")] 
		public animNamedTrackIndex ConeLimitReached
		{
			get
			{
				if (_coneLimitReached == null)
				{
					_coneLimitReached = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "coneLimitReached", cr2w, this);
				}
				return _coneLimitReached;
			}
			set
			{
				if (_coneLimitReached == value)
				{
					return;
				}
				_coneLimitReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("colorfulCone")] 
		public CBool ColorfulCone
		{
			get
			{
				if (_colorfulCone == null)
				{
					_colorfulCone = (CBool) CR2WTypeManager.Create("Bool", "colorfulCone", cr2w, this);
				}
				return _colorfulCone;
			}
			set
			{
				if (_colorfulCone == value)
				{
					return;
				}
				_colorfulCone = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("applyDebugConeScalling")] 
		public CBool ApplyDebugConeScalling
		{
			get
			{
				if (_applyDebugConeScalling == null)
				{
					_applyDebugConeScalling = (CBool) CR2WTypeManager.Create("Bool", "applyDebugConeScalling", cr2w, this);
				}
				return _applyDebugConeScalling;
			}
			set
			{
				if (_applyDebugConeScalling == value)
				{
					return;
				}
				_applyDebugConeScalling = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ConeLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

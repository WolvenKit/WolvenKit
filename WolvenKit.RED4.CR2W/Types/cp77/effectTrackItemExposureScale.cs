using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemExposureScale : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _scale;
		private CBool _useInitialCameraPosDirForFadeout;
		private CFloat _fullEffectRadius;
		private CFloat _fadeOutRadius;
		private CFloat _fullyVisibleAngle;
		private CFloat _fadeOutAngle;

		[Ordinal(3)] 
		[RED("scale")] 
		public effectEffectParameterEvaluatorFloat Scale
		{
			get
			{
				if (_scale == null)
				{
					_scale = (effectEffectParameterEvaluatorFloat) CR2WTypeManager.Create("effectEffectParameterEvaluatorFloat", "scale", cr2w, this);
				}
				return _scale;
			}
			set
			{
				if (_scale == value)
				{
					return;
				}
				_scale = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useInitialCameraPosDirForFadeout")] 
		public CBool UseInitialCameraPosDirForFadeout
		{
			get
			{
				if (_useInitialCameraPosDirForFadeout == null)
				{
					_useInitialCameraPosDirForFadeout = (CBool) CR2WTypeManager.Create("Bool", "useInitialCameraPosDirForFadeout", cr2w, this);
				}
				return _useInitialCameraPosDirForFadeout;
			}
			set
			{
				if (_useInitialCameraPosDirForFadeout == value)
				{
					return;
				}
				_useInitialCameraPosDirForFadeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fullEffectRadius")] 
		public CFloat FullEffectRadius
		{
			get
			{
				if (_fullEffectRadius == null)
				{
					_fullEffectRadius = (CFloat) CR2WTypeManager.Create("Float", "fullEffectRadius", cr2w, this);
				}
				return _fullEffectRadius;
			}
			set
			{
				if (_fullEffectRadius == value)
				{
					return;
				}
				_fullEffectRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fadeOutRadius")] 
		public CFloat FadeOutRadius
		{
			get
			{
				if (_fadeOutRadius == null)
				{
					_fadeOutRadius = (CFloat) CR2WTypeManager.Create("Float", "fadeOutRadius", cr2w, this);
				}
				return _fadeOutRadius;
			}
			set
			{
				if (_fadeOutRadius == value)
				{
					return;
				}
				_fadeOutRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fullyVisibleAngle")] 
		public CFloat FullyVisibleAngle
		{
			get
			{
				if (_fullyVisibleAngle == null)
				{
					_fullyVisibleAngle = (CFloat) CR2WTypeManager.Create("Float", "fullyVisibleAngle", cr2w, this);
				}
				return _fullyVisibleAngle;
			}
			set
			{
				if (_fullyVisibleAngle == value)
				{
					return;
				}
				_fullyVisibleAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fadeOutAngle")] 
		public CFloat FadeOutAngle
		{
			get
			{
				if (_fadeOutAngle == null)
				{
					_fadeOutAngle = (CFloat) CR2WTypeManager.Create("Float", "fadeOutAngle", cr2w, this);
				}
				return _fadeOutAngle;
			}
			set
			{
				if (_fadeOutAngle == value)
				{
					return;
				}
				_fadeOutAngle = value;
				PropertySet(this);
			}
		}

		public effectTrackItemExposureScale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

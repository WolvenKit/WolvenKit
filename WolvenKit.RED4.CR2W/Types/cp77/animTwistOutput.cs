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
			get
			{
				if (_positiveScale == null)
				{
					_positiveScale = (CFloat) CR2WTypeManager.Create("Float", "positiveScale", cr2w, this);
				}
				return _positiveScale;
			}
			set
			{
				if (_positiveScale == value)
				{
					return;
				}
				_positiveScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("negativeScale")] 
		public CFloat NegativeScale
		{
			get
			{
				if (_negativeScale == null)
				{
					_negativeScale = (CFloat) CR2WTypeManager.Create("Float", "negativeScale", cr2w, this);
				}
				return _negativeScale;
			}
			set
			{
				if (_negativeScale == value)
				{
					return;
				}
				_negativeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("twistAxis")] 
		public CEnum<animAxis> TwistAxis
		{
			get
			{
				if (_twistAxis == null)
				{
					_twistAxis = (CEnum<animAxis>) CR2WTypeManager.Create("animAxis", "twistAxis", cr2w, this);
				}
				return _twistAxis;
			}
			set
			{
				if (_twistAxis == value)
				{
					return;
				}
				_twistAxis = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("twistedTransform")] 
		public animTransformIndex TwistedTransform
		{
			get
			{
				if (_twistedTransform == null)
				{
					_twistedTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "twistedTransform", cr2w, this);
				}
				return _twistedTransform;
			}
			set
			{
				if (_twistedTransform == value)
				{
					return;
				}
				_twistedTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("outputAngleTrack")] 
		public animNamedTrackIndex OutputAngleTrack
		{
			get
			{
				if (_outputAngleTrack == null)
				{
					_outputAngleTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "outputAngleTrack", cr2w, this);
				}
				return _outputAngleTrack;
			}
			set
			{
				if (_outputAngleTrack == value)
				{
					return;
				}
				_outputAngleTrack = value;
				PropertySet(this);
			}
		}

		public animTwistOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

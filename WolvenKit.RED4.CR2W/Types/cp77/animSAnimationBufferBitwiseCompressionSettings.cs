using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSAnimationBufferBitwiseCompressionSettings : CVariable
	{
		private CFloat _translationTolerance;
		private CFloat _translationSkipFrameTolerance;
		private CFloat _orientationTolerance;
		private CEnum<SAnimationBufferOrientationCompressionMethod> _orientationCompressionMethod;
		private CFloat _orientationSkipFrameTolerance;
		private CFloat _scaleTolerance;
		private CFloat _scaleSkipFrameTolerance;
		private CFloat _trackTolerance;
		private CFloat _trackSkipFrameTolerance;

		[Ordinal(0)] 
		[RED("translationTolerance")] 
		public CFloat TranslationTolerance
		{
			get
			{
				if (_translationTolerance == null)
				{
					_translationTolerance = (CFloat) CR2WTypeManager.Create("Float", "translationTolerance", cr2w, this);
				}
				return _translationTolerance;
			}
			set
			{
				if (_translationTolerance == value)
				{
					return;
				}
				_translationTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("translationSkipFrameTolerance")] 
		public CFloat TranslationSkipFrameTolerance
		{
			get
			{
				if (_translationSkipFrameTolerance == null)
				{
					_translationSkipFrameTolerance = (CFloat) CR2WTypeManager.Create("Float", "translationSkipFrameTolerance", cr2w, this);
				}
				return _translationSkipFrameTolerance;
			}
			set
			{
				if (_translationSkipFrameTolerance == value)
				{
					return;
				}
				_translationSkipFrameTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("orientationTolerance")] 
		public CFloat OrientationTolerance
		{
			get
			{
				if (_orientationTolerance == null)
				{
					_orientationTolerance = (CFloat) CR2WTypeManager.Create("Float", "orientationTolerance", cr2w, this);
				}
				return _orientationTolerance;
			}
			set
			{
				if (_orientationTolerance == value)
				{
					return;
				}
				_orientationTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("orientationCompressionMethod")] 
		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod
		{
			get
			{
				if (_orientationCompressionMethod == null)
				{
					_orientationCompressionMethod = (CEnum<SAnimationBufferOrientationCompressionMethod>) CR2WTypeManager.Create("SAnimationBufferOrientationCompressionMethod", "orientationCompressionMethod", cr2w, this);
				}
				return _orientationCompressionMethod;
			}
			set
			{
				if (_orientationCompressionMethod == value)
				{
					return;
				}
				_orientationCompressionMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("orientationSkipFrameTolerance")] 
		public CFloat OrientationSkipFrameTolerance
		{
			get
			{
				if (_orientationSkipFrameTolerance == null)
				{
					_orientationSkipFrameTolerance = (CFloat) CR2WTypeManager.Create("Float", "orientationSkipFrameTolerance", cr2w, this);
				}
				return _orientationSkipFrameTolerance;
			}
			set
			{
				if (_orientationSkipFrameTolerance == value)
				{
					return;
				}
				_orientationSkipFrameTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("scaleTolerance")] 
		public CFloat ScaleTolerance
		{
			get
			{
				if (_scaleTolerance == null)
				{
					_scaleTolerance = (CFloat) CR2WTypeManager.Create("Float", "scaleTolerance", cr2w, this);
				}
				return _scaleTolerance;
			}
			set
			{
				if (_scaleTolerance == value)
				{
					return;
				}
				_scaleTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("scaleSkipFrameTolerance")] 
		public CFloat ScaleSkipFrameTolerance
		{
			get
			{
				if (_scaleSkipFrameTolerance == null)
				{
					_scaleSkipFrameTolerance = (CFloat) CR2WTypeManager.Create("Float", "scaleSkipFrameTolerance", cr2w, this);
				}
				return _scaleSkipFrameTolerance;
			}
			set
			{
				if (_scaleSkipFrameTolerance == value)
				{
					return;
				}
				_scaleSkipFrameTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("trackTolerance")] 
		public CFloat TrackTolerance
		{
			get
			{
				if (_trackTolerance == null)
				{
					_trackTolerance = (CFloat) CR2WTypeManager.Create("Float", "trackTolerance", cr2w, this);
				}
				return _trackTolerance;
			}
			set
			{
				if (_trackTolerance == value)
				{
					return;
				}
				_trackTolerance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("trackSkipFrameTolerance")] 
		public CFloat TrackSkipFrameTolerance
		{
			get
			{
				if (_trackSkipFrameTolerance == null)
				{
					_trackSkipFrameTolerance = (CFloat) CR2WTypeManager.Create("Float", "trackSkipFrameTolerance", cr2w, this);
				}
				return _trackSkipFrameTolerance;
			}
			set
			{
				if (_trackSkipFrameTolerance == value)
				{
					return;
				}
				_trackSkipFrameTolerance = value;
				PropertySet(this);
			}
		}

		public animSAnimationBufferBitwiseCompressionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

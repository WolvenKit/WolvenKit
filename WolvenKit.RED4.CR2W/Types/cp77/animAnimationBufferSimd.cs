using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimationBufferSimd : animIAnimationBuffer
	{
		private CFloat _duration;
		private CUInt32 _numFrames;
		private CUInt8 _numExtraJoints;
		private CUInt8 _numExtraTracks;
		private CUInt16 _numJoints;
		private CUInt16 _numTracks;
		private CUInt16 _numTranslationsToCopy;
		private CUInt16 _numTranslationsToEvalAlignedToSimd;
		private CUInt16 _quantizationBits;
		private CBool _isScaleConstant;
		private CBool _isTrackConstant;
		private serializationDeferredDataBuffer _defferedBuffer;
		private DataBuffer _inplaceCompressedBuffer;
		private animAnimFallbackFrameDesc _fallbackFrameDesc;
		private DataBuffer _fallbackFrameBuffer;
		private CArray<CName> _extraDataNames;

		[Ordinal(0)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("numFrames")] 
		public CUInt32 NumFrames
		{
			get
			{
				if (_numFrames == null)
				{
					_numFrames = (CUInt32) CR2WTypeManager.Create("Uint32", "numFrames", cr2w, this);
				}
				return _numFrames;
			}
			set
			{
				if (_numFrames == value)
				{
					return;
				}
				_numFrames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("numExtraJoints")] 
		public CUInt8 NumExtraJoints
		{
			get
			{
				if (_numExtraJoints == null)
				{
					_numExtraJoints = (CUInt8) CR2WTypeManager.Create("Uint8", "numExtraJoints", cr2w, this);
				}
				return _numExtraJoints;
			}
			set
			{
				if (_numExtraJoints == value)
				{
					return;
				}
				_numExtraJoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numExtraTracks")] 
		public CUInt8 NumExtraTracks
		{
			get
			{
				if (_numExtraTracks == null)
				{
					_numExtraTracks = (CUInt8) CR2WTypeManager.Create("Uint8", "numExtraTracks", cr2w, this);
				}
				return _numExtraTracks;
			}
			set
			{
				if (_numExtraTracks == value)
				{
					return;
				}
				_numExtraTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("numJoints")] 
		public CUInt16 NumJoints
		{
			get
			{
				if (_numJoints == null)
				{
					_numJoints = (CUInt16) CR2WTypeManager.Create("Uint16", "numJoints", cr2w, this);
				}
				return _numJoints;
			}
			set
			{
				if (_numJoints == value)
				{
					return;
				}
				_numJoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("numTracks")] 
		public CUInt16 NumTracks
		{
			get
			{
				if (_numTracks == null)
				{
					_numTracks = (CUInt16) CR2WTypeManager.Create("Uint16", "numTracks", cr2w, this);
				}
				return _numTracks;
			}
			set
			{
				if (_numTracks == value)
				{
					return;
				}
				_numTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("numTranslationsToCopy")] 
		public CUInt16 NumTranslationsToCopy
		{
			get
			{
				if (_numTranslationsToCopy == null)
				{
					_numTranslationsToCopy = (CUInt16) CR2WTypeManager.Create("Uint16", "numTranslationsToCopy", cr2w, this);
				}
				return _numTranslationsToCopy;
			}
			set
			{
				if (_numTranslationsToCopy == value)
				{
					return;
				}
				_numTranslationsToCopy = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("numTranslationsToEvalAlignedToSimd")] 
		public CUInt16 NumTranslationsToEvalAlignedToSimd
		{
			get
			{
				if (_numTranslationsToEvalAlignedToSimd == null)
				{
					_numTranslationsToEvalAlignedToSimd = (CUInt16) CR2WTypeManager.Create("Uint16", "numTranslationsToEvalAlignedToSimd", cr2w, this);
				}
				return _numTranslationsToEvalAlignedToSimd;
			}
			set
			{
				if (_numTranslationsToEvalAlignedToSimd == value)
				{
					return;
				}
				_numTranslationsToEvalAlignedToSimd = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("quantizationBits")] 
		public CUInt16 QuantizationBits
		{
			get
			{
				if (_quantizationBits == null)
				{
					_quantizationBits = (CUInt16) CR2WTypeManager.Create("Uint16", "quantizationBits", cr2w, this);
				}
				return _quantizationBits;
			}
			set
			{
				if (_quantizationBits == value)
				{
					return;
				}
				_quantizationBits = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("isScaleConstant")] 
		public CBool IsScaleConstant
		{
			get
			{
				if (_isScaleConstant == null)
				{
					_isScaleConstant = (CBool) CR2WTypeManager.Create("Bool", "isScaleConstant", cr2w, this);
				}
				return _isScaleConstant;
			}
			set
			{
				if (_isScaleConstant == value)
				{
					return;
				}
				_isScaleConstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isTrackConstant")] 
		public CBool IsTrackConstant
		{
			get
			{
				if (_isTrackConstant == null)
				{
					_isTrackConstant = (CBool) CR2WTypeManager.Create("Bool", "isTrackConstant", cr2w, this);
				}
				return _isTrackConstant;
			}
			set
			{
				if (_isTrackConstant == value)
				{
					return;
				}
				_isTrackConstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("defferedBuffer")] 
		public serializationDeferredDataBuffer DefferedBuffer
		{
			get
			{
				if (_defferedBuffer == null)
				{
					_defferedBuffer = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "defferedBuffer", cr2w, this);
				}
				return _defferedBuffer;
			}
			set
			{
				if (_defferedBuffer == value)
				{
					return;
				}
				_defferedBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inplaceCompressedBuffer")] 
		public DataBuffer InplaceCompressedBuffer
		{
			get
			{
				if (_inplaceCompressedBuffer == null)
				{
					_inplaceCompressedBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "inplaceCompressedBuffer", cr2w, this);
				}
				return _inplaceCompressedBuffer;
			}
			set
			{
				if (_inplaceCompressedBuffer == value)
				{
					return;
				}
				_inplaceCompressedBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fallbackFrameDesc")] 
		public animAnimFallbackFrameDesc FallbackFrameDesc
		{
			get
			{
				if (_fallbackFrameDesc == null)
				{
					_fallbackFrameDesc = (animAnimFallbackFrameDesc) CR2WTypeManager.Create("animAnimFallbackFrameDesc", "fallbackFrameDesc", cr2w, this);
				}
				return _fallbackFrameDesc;
			}
			set
			{
				if (_fallbackFrameDesc == value)
				{
					return;
				}
				_fallbackFrameDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fallbackFrameBuffer")] 
		public DataBuffer FallbackFrameBuffer
		{
			get
			{
				if (_fallbackFrameBuffer == null)
				{
					_fallbackFrameBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "fallbackFrameBuffer", cr2w, this);
				}
				return _fallbackFrameBuffer;
			}
			set
			{
				if (_fallbackFrameBuffer == value)
				{
					return;
				}
				_fallbackFrameBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get
			{
				if (_extraDataNames == null)
				{
					_extraDataNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "extraDataNames", cr2w, this);
				}
				return _extraDataNames;
			}
			set
			{
				if (_extraDataNames == value)
				{
					return;
				}
				_extraDataNames = value;
				PropertySet(this);
			}
		}

		public animAnimationBufferSimd(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

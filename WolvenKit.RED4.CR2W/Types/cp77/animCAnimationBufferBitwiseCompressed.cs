using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCAnimationBufferBitwiseCompressed : animIAnimationBuffer
	{
		private CUInt32 _version;
		private CArray<animSAnimationBufferBitwiseCompressedBoneTrack> _bones;
		private CArray<animSAnimationBufferBitwiseCompressedData> _tracks;
		private CArray<CInt8> _data;
		private CArray<CInt8> _fallbackData;
		private serializationDeferredDataBuffer _deferredData;
		private CEnum<SAnimationBufferOrientationCompressionMethod> _orientationCompressionMethod;
		private CFloat _duration;
		private CUInt32 _numFrames;
		private CFloat _dt;
		private CEnum<SAnimationBufferStreamingOption> _streamingOption;
		private CUInt32 _nonStreamableBones;
		private CArray<CName> _extraDataNames;
		private CUInt32 _numExtraBones;

		[Ordinal(0)] 
		[RED("version")] 
		public CUInt32 Version
		{
			get
			{
				if (_version == null)
				{
					_version = (CUInt32) CR2WTypeManager.Create("Uint32", "version", cr2w, this);
				}
				return _version;
			}
			set
			{
				if (_version == value)
				{
					return;
				}
				_version = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<animSAnimationBufferBitwiseCompressedBoneTrack> Bones
		{
			get
			{
				if (_bones == null)
				{
					_bones = (CArray<animSAnimationBufferBitwiseCompressedBoneTrack>) CR2WTypeManager.Create("array:animSAnimationBufferBitwiseCompressedBoneTrack", "bones", cr2w, this);
				}
				return _bones;
			}
			set
			{
				if (_bones == value)
				{
					return;
				}
				_bones = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<animSAnimationBufferBitwiseCompressedData> Tracks
		{
			get
			{
				if (_tracks == null)
				{
					_tracks = (CArray<animSAnimationBufferBitwiseCompressedData>) CR2WTypeManager.Create("array:animSAnimationBufferBitwiseCompressedData", "tracks", cr2w, this);
				}
				return _tracks;
			}
			set
			{
				if (_tracks == value)
				{
					return;
				}
				_tracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CInt8> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CArray<CInt8>) CR2WTypeManager.Create("array:Int8", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fallbackData")] 
		public CArray<CInt8> FallbackData
		{
			get
			{
				if (_fallbackData == null)
				{
					_fallbackData = (CArray<CInt8>) CR2WTypeManager.Create("array:Int8", "fallbackData", cr2w, this);
				}
				return _fallbackData;
			}
			set
			{
				if (_fallbackData == value)
				{
					return;
				}
				_fallbackData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("deferredData")] 
		public serializationDeferredDataBuffer DeferredData
		{
			get
			{
				if (_deferredData == null)
				{
					_deferredData = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "deferredData", cr2w, this);
				}
				return _deferredData;
			}
			set
			{
				if (_deferredData == value)
				{
					return;
				}
				_deferredData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get
			{
				if (_dt == null)
				{
					_dt = (CFloat) CR2WTypeManager.Create("Float", "dt", cr2w, this);
				}
				return _dt;
			}
			set
			{
				if (_dt == value)
				{
					return;
				}
				_dt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("streamingOption")] 
		public CEnum<SAnimationBufferStreamingOption> StreamingOption
		{
			get
			{
				if (_streamingOption == null)
				{
					_streamingOption = (CEnum<SAnimationBufferStreamingOption>) CR2WTypeManager.Create("SAnimationBufferStreamingOption", "streamingOption", cr2w, this);
				}
				return _streamingOption;
			}
			set
			{
				if (_streamingOption == value)
				{
					return;
				}
				_streamingOption = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("nonStreamableBones")] 
		public CUInt32 NonStreamableBones
		{
			get
			{
				if (_nonStreamableBones == null)
				{
					_nonStreamableBones = (CUInt32) CR2WTypeManager.Create("Uint32", "nonStreamableBones", cr2w, this);
				}
				return _nonStreamableBones;
			}
			set
			{
				if (_nonStreamableBones == value)
				{
					return;
				}
				_nonStreamableBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
		[RED("numExtraBones")] 
		public CUInt32 NumExtraBones
		{
			get
			{
				if (_numExtraBones == null)
				{
					_numExtraBones = (CUInt32) CR2WTypeManager.Create("Uint32", "numExtraBones", cr2w, this);
				}
				return _numExtraBones;
			}
			set
			{
				if (_numExtraBones == value)
				{
					return;
				}
				_numExtraBones = value;
				PropertySet(this);
			}
		}

		public animCAnimationBufferBitwiseCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

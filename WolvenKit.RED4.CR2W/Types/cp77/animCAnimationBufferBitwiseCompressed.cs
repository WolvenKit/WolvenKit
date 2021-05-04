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
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		[Ordinal(1)] 
		[RED("bones")] 
		public CArray<animSAnimationBufferBitwiseCompressedBoneTrack> Bones
		{
			get => GetProperty(ref _bones);
			set => SetProperty(ref _bones, value);
		}

		[Ordinal(2)] 
		[RED("tracks")] 
		public CArray<animSAnimationBufferBitwiseCompressedData> Tracks
		{
			get => GetProperty(ref _tracks);
			set => SetProperty(ref _tracks, value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<CInt8> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("fallbackData")] 
		public CArray<CInt8> FallbackData
		{
			get => GetProperty(ref _fallbackData);
			set => SetProperty(ref _fallbackData, value);
		}

		[Ordinal(5)] 
		[RED("deferredData")] 
		public serializationDeferredDataBuffer DeferredData
		{
			get => GetProperty(ref _deferredData);
			set => SetProperty(ref _deferredData, value);
		}

		[Ordinal(6)] 
		[RED("orientationCompressionMethod")] 
		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod
		{
			get => GetProperty(ref _orientationCompressionMethod);
			set => SetProperty(ref _orientationCompressionMethod, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(8)] 
		[RED("numFrames")] 
		public CUInt32 NumFrames
		{
			get => GetProperty(ref _numFrames);
			set => SetProperty(ref _numFrames, value);
		}

		[Ordinal(9)] 
		[RED("dt")] 
		public CFloat Dt
		{
			get => GetProperty(ref _dt);
			set => SetProperty(ref _dt, value);
		}

		[Ordinal(10)] 
		[RED("streamingOption")] 
		public CEnum<SAnimationBufferStreamingOption> StreamingOption
		{
			get => GetProperty(ref _streamingOption);
			set => SetProperty(ref _streamingOption, value);
		}

		[Ordinal(11)] 
		[RED("nonStreamableBones")] 
		public CUInt32 NonStreamableBones
		{
			get => GetProperty(ref _nonStreamableBones);
			set => SetProperty(ref _nonStreamableBones, value);
		}

		[Ordinal(12)] 
		[RED("extraDataNames")] 
		public CArray<CName> ExtraDataNames
		{
			get => GetProperty(ref _extraDataNames);
			set => SetProperty(ref _extraDataNames, value);
		}

		[Ordinal(13)] 
		[RED("numExtraBones")] 
		public CUInt32 NumExtraBones
		{
			get => GetProperty(ref _numExtraBones);
			set => SetProperty(ref _numExtraBones, value);
		}

		public animCAnimationBufferBitwiseCompressed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

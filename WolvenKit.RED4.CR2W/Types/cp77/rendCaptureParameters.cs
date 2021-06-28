using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendCaptureParameters : CVariable
	{
		private CBool _enable;
		private CEnum<rendScreenshotMode> _mode;
		private CBool _videoRecordingMode;
		private CBool _audioRecordingMode;
		private CArray<CEnum<EEnvManagerModifier>> _emmModes;
		private CUInt32 _initialFrameNumber;
		private CUInt32 _outputDirectoryIndex;
		private CString _outputDirectoryName;
		private CString _outputDirectoryNameSuffix;
		private CUInt32 _recordingFPS;
		private Point _customResolution;
		private CEnum<rendResolutionMultiplier> _resolutionMultiplier;
		private AbsolutePathSerializable _outputPath;
		private CFloat _fovMultiplier;
		private CEnum<rendCaptureContextType> _captureContextType;
		private CEnum<ESaveFormat> _saveFormat;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<rendScreenshotMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(2)] 
		[RED("videoRecordingMode")] 
		public CBool VideoRecordingMode
		{
			get => GetProperty(ref _videoRecordingMode);
			set => SetProperty(ref _videoRecordingMode, value);
		}

		[Ordinal(3)] 
		[RED("audioRecordingMode")] 
		public CBool AudioRecordingMode
		{
			get => GetProperty(ref _audioRecordingMode);
			set => SetProperty(ref _audioRecordingMode, value);
		}

		[Ordinal(4)] 
		[RED("emmModes")] 
		public CArray<CEnum<EEnvManagerModifier>> EmmModes
		{
			get => GetProperty(ref _emmModes);
			set => SetProperty(ref _emmModes, value);
		}

		[Ordinal(5)] 
		[RED("initialFrameNumber")] 
		public CUInt32 InitialFrameNumber
		{
			get => GetProperty(ref _initialFrameNumber);
			set => SetProperty(ref _initialFrameNumber, value);
		}

		[Ordinal(6)] 
		[RED("outputDirectoryIndex")] 
		public CUInt32 OutputDirectoryIndex
		{
			get => GetProperty(ref _outputDirectoryIndex);
			set => SetProperty(ref _outputDirectoryIndex, value);
		}

		[Ordinal(7)] 
		[RED("outputDirectoryName")] 
		public CString OutputDirectoryName
		{
			get => GetProperty(ref _outputDirectoryName);
			set => SetProperty(ref _outputDirectoryName, value);
		}

		[Ordinal(8)] 
		[RED("outputDirectoryNameSuffix")] 
		public CString OutputDirectoryNameSuffix
		{
			get => GetProperty(ref _outputDirectoryNameSuffix);
			set => SetProperty(ref _outputDirectoryNameSuffix, value);
		}

		[Ordinal(9)] 
		[RED("recordingFPS")] 
		public CUInt32 RecordingFPS
		{
			get => GetProperty(ref _recordingFPS);
			set => SetProperty(ref _recordingFPS, value);
		}

		[Ordinal(10)] 
		[RED("customResolution")] 
		public Point CustomResolution
		{
			get => GetProperty(ref _customResolution);
			set => SetProperty(ref _customResolution, value);
		}

		[Ordinal(11)] 
		[RED("resolutionMultiplier")] 
		public CEnum<rendResolutionMultiplier> ResolutionMultiplier
		{
			get => GetProperty(ref _resolutionMultiplier);
			set => SetProperty(ref _resolutionMultiplier, value);
		}

		[Ordinal(12)] 
		[RED("outputPath")] 
		public AbsolutePathSerializable OutputPath
		{
			get => GetProperty(ref _outputPath);
			set => SetProperty(ref _outputPath, value);
		}

		[Ordinal(13)] 
		[RED("fovMultiplier")] 
		public CFloat FovMultiplier
		{
			get => GetProperty(ref _fovMultiplier);
			set => SetProperty(ref _fovMultiplier, value);
		}

		[Ordinal(14)] 
		[RED("captureContextType")] 
		public CEnum<rendCaptureContextType> CaptureContextType
		{
			get => GetProperty(ref _captureContextType);
			set => SetProperty(ref _captureContextType, value);
		}

		[Ordinal(15)] 
		[RED("saveFormat")] 
		public CEnum<ESaveFormat> SaveFormat
		{
			get => GetProperty(ref _saveFormat);
			set => SetProperty(ref _saveFormat, value);
		}

		public rendCaptureParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

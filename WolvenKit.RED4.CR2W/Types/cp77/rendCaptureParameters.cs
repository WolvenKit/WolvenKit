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
			get
			{
				if (_enable == null)
				{
					_enable = (CBool) CR2WTypeManager.Create("Bool", "enable", cr2w, this);
				}
				return _enable;
			}
			set
			{
				if (_enable == value)
				{
					return;
				}
				_enable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<rendScreenshotMode> Mode
		{
			get
			{
				if (_mode == null)
				{
					_mode = (CEnum<rendScreenshotMode>) CR2WTypeManager.Create("rendScreenshotMode", "mode", cr2w, this);
				}
				return _mode;
			}
			set
			{
				if (_mode == value)
				{
					return;
				}
				_mode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("videoRecordingMode")] 
		public CBool VideoRecordingMode
		{
			get
			{
				if (_videoRecordingMode == null)
				{
					_videoRecordingMode = (CBool) CR2WTypeManager.Create("Bool", "videoRecordingMode", cr2w, this);
				}
				return _videoRecordingMode;
			}
			set
			{
				if (_videoRecordingMode == value)
				{
					return;
				}
				_videoRecordingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("audioRecordingMode")] 
		public CBool AudioRecordingMode
		{
			get
			{
				if (_audioRecordingMode == null)
				{
					_audioRecordingMode = (CBool) CR2WTypeManager.Create("Bool", "audioRecordingMode", cr2w, this);
				}
				return _audioRecordingMode;
			}
			set
			{
				if (_audioRecordingMode == value)
				{
					return;
				}
				_audioRecordingMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("emmModes")] 
		public CArray<CEnum<EEnvManagerModifier>> EmmModes
		{
			get
			{
				if (_emmModes == null)
				{
					_emmModes = (CArray<CEnum<EEnvManagerModifier>>) CR2WTypeManager.Create("array:EEnvManagerModifier", "emmModes", cr2w, this);
				}
				return _emmModes;
			}
			set
			{
				if (_emmModes == value)
				{
					return;
				}
				_emmModes = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("initialFrameNumber")] 
		public CUInt32 InitialFrameNumber
		{
			get
			{
				if (_initialFrameNumber == null)
				{
					_initialFrameNumber = (CUInt32) CR2WTypeManager.Create("Uint32", "initialFrameNumber", cr2w, this);
				}
				return _initialFrameNumber;
			}
			set
			{
				if (_initialFrameNumber == value)
				{
					return;
				}
				_initialFrameNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("outputDirectoryIndex")] 
		public CUInt32 OutputDirectoryIndex
		{
			get
			{
				if (_outputDirectoryIndex == null)
				{
					_outputDirectoryIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "outputDirectoryIndex", cr2w, this);
				}
				return _outputDirectoryIndex;
			}
			set
			{
				if (_outputDirectoryIndex == value)
				{
					return;
				}
				_outputDirectoryIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("outputDirectoryName")] 
		public CString OutputDirectoryName
		{
			get
			{
				if (_outputDirectoryName == null)
				{
					_outputDirectoryName = (CString) CR2WTypeManager.Create("String", "outputDirectoryName", cr2w, this);
				}
				return _outputDirectoryName;
			}
			set
			{
				if (_outputDirectoryName == value)
				{
					return;
				}
				_outputDirectoryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("outputDirectoryNameSuffix")] 
		public CString OutputDirectoryNameSuffix
		{
			get
			{
				if (_outputDirectoryNameSuffix == null)
				{
					_outputDirectoryNameSuffix = (CString) CR2WTypeManager.Create("String", "outputDirectoryNameSuffix", cr2w, this);
				}
				return _outputDirectoryNameSuffix;
			}
			set
			{
				if (_outputDirectoryNameSuffix == value)
				{
					return;
				}
				_outputDirectoryNameSuffix = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("recordingFPS")] 
		public CUInt32 RecordingFPS
		{
			get
			{
				if (_recordingFPS == null)
				{
					_recordingFPS = (CUInt32) CR2WTypeManager.Create("Uint32", "recordingFPS", cr2w, this);
				}
				return _recordingFPS;
			}
			set
			{
				if (_recordingFPS == value)
				{
					return;
				}
				_recordingFPS = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customResolution")] 
		public Point CustomResolution
		{
			get
			{
				if (_customResolution == null)
				{
					_customResolution = (Point) CR2WTypeManager.Create("Point", "customResolution", cr2w, this);
				}
				return _customResolution;
			}
			set
			{
				if (_customResolution == value)
				{
					return;
				}
				_customResolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("resolutionMultiplier")] 
		public CEnum<rendResolutionMultiplier> ResolutionMultiplier
		{
			get
			{
				if (_resolutionMultiplier == null)
				{
					_resolutionMultiplier = (CEnum<rendResolutionMultiplier>) CR2WTypeManager.Create("rendResolutionMultiplier", "resolutionMultiplier", cr2w, this);
				}
				return _resolutionMultiplier;
			}
			set
			{
				if (_resolutionMultiplier == value)
				{
					return;
				}
				_resolutionMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("outputPath")] 
		public AbsolutePathSerializable OutputPath
		{
			get
			{
				if (_outputPath == null)
				{
					_outputPath = (AbsolutePathSerializable) CR2WTypeManager.Create("AbsolutePathSerializable", "outputPath", cr2w, this);
				}
				return _outputPath;
			}
			set
			{
				if (_outputPath == value)
				{
					return;
				}
				_outputPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fovMultiplier")] 
		public CFloat FovMultiplier
		{
			get
			{
				if (_fovMultiplier == null)
				{
					_fovMultiplier = (CFloat) CR2WTypeManager.Create("Float", "fovMultiplier", cr2w, this);
				}
				return _fovMultiplier;
			}
			set
			{
				if (_fovMultiplier == value)
				{
					return;
				}
				_fovMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("captureContextType")] 
		public CEnum<rendCaptureContextType> CaptureContextType
		{
			get
			{
				if (_captureContextType == null)
				{
					_captureContextType = (CEnum<rendCaptureContextType>) CR2WTypeManager.Create("rendCaptureContextType", "captureContextType", cr2w, this);
				}
				return _captureContextType;
			}
			set
			{
				if (_captureContextType == value)
				{
					return;
				}
				_captureContextType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("saveFormat")] 
		public CEnum<ESaveFormat> SaveFormat
		{
			get
			{
				if (_saveFormat == null)
				{
					_saveFormat = (CEnum<ESaveFormat>) CR2WTypeManager.Create("ESaveFormat", "saveFormat", cr2w, this);
				}
				return _saveFormat;
			}
			set
			{
				if (_saveFormat == value)
				{
					return;
				}
				_saveFormat = value;
				PropertySet(this);
			}
		}

		public rendCaptureParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

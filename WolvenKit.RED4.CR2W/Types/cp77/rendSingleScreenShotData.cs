using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendSingleScreenShotData : ISerializable
	{
		private CEnum<rendScreenshotMode> _mode;
		private AbsolutePathSerializable _outputPath;
		private CEnum<renddimEPreset> _resolution;
		private CEnum<rendResolutionMultiplier> _resolutionMultiplier;
		private CArray<CEnum<EEnvManagerModifier>> _emmModes;
		private CBool _forceLOD0;
		private CEnum<ESaveFormat> _saveFormat;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("resolution")] 
		public CEnum<renddimEPreset> Resolution
		{
			get
			{
				if (_resolution == null)
				{
					_resolution = (CEnum<renddimEPreset>) CR2WTypeManager.Create("renddimEPreset", "resolution", cr2w, this);
				}
				return _resolution;
			}
			set
			{
				if (_resolution == value)
				{
					return;
				}
				_resolution = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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
		[RED("forceLOD0")] 
		public CBool ForceLOD0
		{
			get
			{
				if (_forceLOD0 == null)
				{
					_forceLOD0 = (CBool) CR2WTypeManager.Create("Bool", "forceLOD0", cr2w, this);
				}
				return _forceLOD0;
			}
			set
			{
				if (_forceLOD0 == value)
				{
					return;
				}
				_forceLOD0 = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		public rendSingleScreenShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(1)] 
		[RED("outputPath")] 
		public AbsolutePathSerializable OutputPath
		{
			get => GetProperty(ref _outputPath);
			set => SetProperty(ref _outputPath, value);
		}

		[Ordinal(2)] 
		[RED("resolution")] 
		public CEnum<renddimEPreset> Resolution
		{
			get => GetProperty(ref _resolution);
			set => SetProperty(ref _resolution, value);
		}

		[Ordinal(3)] 
		[RED("resolutionMultiplier")] 
		public CEnum<rendResolutionMultiplier> ResolutionMultiplier
		{
			get => GetProperty(ref _resolutionMultiplier);
			set => SetProperty(ref _resolutionMultiplier, value);
		}

		[Ordinal(4)] 
		[RED("emmModes")] 
		public CArray<CEnum<EEnvManagerModifier>> EmmModes
		{
			get => GetProperty(ref _emmModes);
			set => SetProperty(ref _emmModes, value);
		}

		[Ordinal(5)] 
		[RED("forceLOD0")] 
		public CBool ForceLOD0
		{
			get => GetProperty(ref _forceLOD0);
			set => SetProperty(ref _forceLOD0, value);
		}

		[Ordinal(6)] 
		[RED("saveFormat")] 
		public CEnum<ESaveFormat> SaveFormat
		{
			get => GetProperty(ref _saveFormat);
			set => SetProperty(ref _saveFormat, value);
		}

		public rendSingleScreenShotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

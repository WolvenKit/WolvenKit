using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_MetricsUsageAbstractBase : worldEditorDebugColoringSettings
	{
		private CColor _maxColor;
		private CColor _minColor;
		private CUInt32 _minSize;
		private CUInt32 _maxSize;

		[Ordinal(0)] 
		[RED("maxColor")] 
		public CColor MaxColor
		{
			get => GetProperty(ref _maxColor);
			set => SetProperty(ref _maxColor, value);
		}

		[Ordinal(1)] 
		[RED("minColor")] 
		public CColor MinColor
		{
			get => GetProperty(ref _minColor);
			set => SetProperty(ref _minColor, value);
		}

		[Ordinal(2)] 
		[RED("minSize")] 
		public CUInt32 MinSize
		{
			get => GetProperty(ref _minSize);
			set => SetProperty(ref _minSize, value);
		}

		[Ordinal(3)] 
		[RED("maxSize")] 
		public CUInt32 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		public worldDebugColoring_MetricsUsageAbstractBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

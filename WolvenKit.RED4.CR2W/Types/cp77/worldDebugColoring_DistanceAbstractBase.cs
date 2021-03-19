using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_DistanceAbstractBase : worldEditorDebugColoringSettings
	{
		private CColor _maxColor;
		private CColor _minColor;
		private CFloat _minDistance;
		private CFloat _maxDistance;

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
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(3)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		public worldDebugColoring_DistanceAbstractBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

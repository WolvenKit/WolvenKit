using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_TrianglesPerMesh : worldEditorDebugColoringSettings
	{
		private CColor _maxColor;
		private CColor _minColor;
		private CUInt32 _minCount;
		private CUInt32 _maxCount;

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
		[RED("minCount")] 
		public CUInt32 MinCount
		{
			get => GetProperty(ref _minCount);
			set => SetProperty(ref _minCount, value);
		}

		[Ordinal(3)] 
		[RED("maxCount")] 
		public CUInt32 MaxCount
		{
			get => GetProperty(ref _maxCount);
			set => SetProperty(ref _maxCount, value);
		}

		public worldDebugColoring_TrianglesPerMesh(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

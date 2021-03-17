using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionAppearance : CVariable
	{
		private CInt32 _fill;
		private CInt32 _outline;
		private CBool _showThroughWalls;
		private CEnum<gameVisionModePatternType> _patternType;

		[Ordinal(0)] 
		[RED("fill")] 
		public CInt32 Fill
		{
			get => GetProperty(ref _fill);
			set => SetProperty(ref _fill, value);
		}

		[Ordinal(1)] 
		[RED("outline")] 
		public CInt32 Outline
		{
			get => GetProperty(ref _outline);
			set => SetProperty(ref _outline, value);
		}

		[Ordinal(2)] 
		[RED("showThroughWalls")] 
		public CBool ShowThroughWalls
		{
			get => GetProperty(ref _showThroughWalls);
			set => SetProperty(ref _showThroughWalls, value);
		}

		[Ordinal(3)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get => GetProperty(ref _patternType);
			set => SetProperty(ref _patternType, value);
		}

		public gameVisionAppearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionAppearance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("fill")] 
		public CInt32 Fill
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("outline")] 
		public CInt32 Outline
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("showThroughWalls")] 
		public CBool ShowThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("patternType")] 
		public CEnum<gameVisionModePatternType> PatternType
		{
			get => GetPropertyValue<CEnum<gameVisionModePatternType>>();
			set => SetPropertyValue<CEnum<gameVisionModePatternType>>(value);
		}

		public gameVisionAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

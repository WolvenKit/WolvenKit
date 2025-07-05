using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerLevel : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isHard")] 
		public CBool IsHard
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerLevel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

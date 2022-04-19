using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SideScrollerMiniGameScoreSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("scoreData", 3)] 
		public CArrayFixedSize<CInt32> ScoreData
		{
			get => GetPropertyValue<CArrayFixedSize<CInt32>>();
			set => SetPropertyValue<CArrayFixedSize<CInt32>>(value);
		}

		[Ordinal(1)] 
		[RED("gameNames", 3)] 
		public CArrayFixedSize<CString> GameNames
		{
			get => GetPropertyValue<CArrayFixedSize<CString>>();
			set => SetPropertyValue<CArrayFixedSize<CString>>(value);
		}

		public SideScrollerMiniGameScoreSystem()
		{
			ScoreData = new(3);
			GameNames = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

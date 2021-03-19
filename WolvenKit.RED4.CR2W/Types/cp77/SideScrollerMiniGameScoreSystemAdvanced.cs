using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SideScrollerMiniGameScoreSystemAdvanced : gameScriptableSystem
	{
		private CArrayFixedSize<CInt32> _scoreData;
		private CArrayFixedSize<CString> _gameNames;

		[Ordinal(0)] 
		[RED("scoreData", 3)] 
		public CArrayFixedSize<CInt32> ScoreData
		{
			get => GetProperty(ref _scoreData);
			set => SetProperty(ref _scoreData, value);
		}

		[Ordinal(1)] 
		[RED("gameNames", 3)] 
		public CArrayFixedSize<CString> GameNames
		{
			get => GetProperty(ref _gameNames);
			set => SetProperty(ref _gameNames, value);
		}

		public SideScrollerMiniGameScoreSystemAdvanced(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

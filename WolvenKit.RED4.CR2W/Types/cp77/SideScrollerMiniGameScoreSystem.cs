using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SideScrollerMiniGameScoreSystem : gameScriptableSystem
	{
		private CArrayFixedSize<CInt32> _scoreData;
		private CArrayFixedSize<CString> _gameNames;

		[Ordinal(0)] 
		[RED("scoreData", 3)] 
		public CArrayFixedSize<CInt32> ScoreData
		{
			get
			{
				if (_scoreData == null)
				{
					_scoreData = (CArrayFixedSize<CInt32>) CR2WTypeManager.Create("[3]Int32", "scoreData", cr2w, this);
				}
				return _scoreData;
			}
			set
			{
				if (_scoreData == value)
				{
					return;
				}
				_scoreData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameNames", 3)] 
		public CArrayFixedSize<CString> GameNames
		{
			get
			{
				if (_gameNames == null)
				{
					_gameNames = (CArrayFixedSize<CString>) CR2WTypeManager.Create("[3]String", "gameNames", cr2w, this);
				}
				return _gameNames;
			}
			set
			{
				if (_gameNames == value)
				{
					return;
				}
				_gameNames = value;
				PropertySet(this);
			}
		}

		public SideScrollerMiniGameScoreSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

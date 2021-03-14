using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScoreboardPlayer : CVariable
	{
		private CString _playerName;
		private CInt32 _playerScore;

		[Ordinal(0)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get
			{
				if (_playerName == null)
				{
					_playerName = (CString) CR2WTypeManager.Create("String", "playerName", cr2w, this);
				}
				return _playerName;
			}
			set
			{
				if (_playerName == value)
				{
					return;
				}
				_playerName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("playerScore")] 
		public CInt32 PlayerScore
		{
			get
			{
				if (_playerScore == null)
				{
					_playerScore = (CInt32) CR2WTypeManager.Create("Int32", "playerScore", cr2w, this);
				}
				return _playerScore;
			}
			set
			{
				if (_playerScore == value)
				{
					return;
				}
				_playerScore = value;
				PropertySet(this);
			}
		}

		public ScoreboardPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

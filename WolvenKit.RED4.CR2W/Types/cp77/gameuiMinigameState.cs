using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameState : IScriptable
	{
		private CInt32 _currentLives;
		private CInt32 _currentScore;

		[Ordinal(0)] 
		[RED("currentLives")] 
		public CInt32 CurrentLives
		{
			get
			{
				if (_currentLives == null)
				{
					_currentLives = (CInt32) CR2WTypeManager.Create("Int32", "currentLives", cr2w, this);
				}
				return _currentLives;
			}
			set
			{
				if (_currentLives == value)
				{
					return;
				}
				_currentLives = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentScore")] 
		public CInt32 CurrentScore
		{
			get
			{
				if (_currentScore == null)
				{
					_currentScore = (CInt32) CR2WTypeManager.Create("Int32", "currentScore", cr2w, this);
				}
				return _currentScore;
			}
			set
			{
				if (_currentScore == value)
				{
					return;
				}
				_currentScore = value;
				PropertySet(this);
			}
		}

		public gameuiMinigameState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

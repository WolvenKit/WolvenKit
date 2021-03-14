using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CreditsData : inkUserData
	{
		private CBool _isFinalBoards;
		private CBool _showRewardPrompt;

		[Ordinal(0)] 
		[RED("isFinalBoards")] 
		public CBool IsFinalBoards
		{
			get
			{
				if (_isFinalBoards == null)
				{
					_isFinalBoards = (CBool) CR2WTypeManager.Create("Bool", "isFinalBoards", cr2w, this);
				}
				return _isFinalBoards;
			}
			set
			{
				if (_isFinalBoards == value)
				{
					return;
				}
				_isFinalBoards = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("showRewardPrompt")] 
		public CBool ShowRewardPrompt
		{
			get
			{
				if (_showRewardPrompt == null)
				{
					_showRewardPrompt = (CBool) CR2WTypeManager.Create("Bool", "showRewardPrompt", cr2w, this);
				}
				return _showRewardPrompt;
			}
			set
			{
				if (_showRewardPrompt == value)
				{
					return;
				}
				_showRewardPrompt = value;
				PropertySet(this);
			}
		}

		public CreditsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

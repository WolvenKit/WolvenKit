using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SendScoreRequest : gameScriptableSystemRequest
	{
		private CInt32 _score;
		private CString _gameName;

		[Ordinal(0)] 
		[RED("score")] 
		public CInt32 Score
		{
			get
			{
				if (_score == null)
				{
					_score = (CInt32) CR2WTypeManager.Create("Int32", "score", cr2w, this);
				}
				return _score;
			}
			set
			{
				if (_score == value)
				{
					return;
				}
				_score = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get
			{
				if (_gameName == null)
				{
					_gameName = (CString) CR2WTypeManager.Create("String", "gameName", cr2w, this);
				}
				return _gameName;
			}
			set
			{
				if (_gameName == value)
				{
					return;
				}
				_gameName = value;
				PropertySet(this);
			}
		}

		public SendScoreRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

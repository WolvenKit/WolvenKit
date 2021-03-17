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
			get => GetProperty(ref _score);
			set => SetProperty(ref _score, value);
		}

		[Ordinal(1)] 
		[RED("gameName")] 
		public CString GameName
		{
			get => GetProperty(ref _gameName);
			set => SetProperty(ref _gameName, value);
		}

		public SendScoreRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

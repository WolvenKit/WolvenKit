using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinigameProgramData : CVariable
	{
		private TweakDBID _actionID;
		private CName _programName;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("programName")] 
		public CName ProgramName
		{
			get => GetProperty(ref _programName);
			set => SetProperty(ref _programName, value);
		}

		public gameuiMinigameProgramData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

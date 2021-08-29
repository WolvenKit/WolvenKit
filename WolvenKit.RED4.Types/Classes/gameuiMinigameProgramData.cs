using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinigameProgramData : RedBaseClass
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
	}
}

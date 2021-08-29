using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSwitchToScenario_NodeType : questIUIManagerNodeType
	{
		private CName _startScenarioName;
		private CName _endScenarioName;
		private CHandle<inkUserData> _userData;
		private CBool _forceOpenDuringFadeout;

		[Ordinal(0)] 
		[RED("startScenarioName")] 
		public CName StartScenarioName
		{
			get => GetProperty(ref _startScenarioName);
			set => SetProperty(ref _startScenarioName, value);
		}

		[Ordinal(1)] 
		[RED("endScenarioName")] 
		public CName EndScenarioName
		{
			get => GetProperty(ref _endScenarioName);
			set => SetProperty(ref _endScenarioName, value);
		}

		[Ordinal(2)] 
		[RED("userData")] 
		public CHandle<inkUserData> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(3)] 
		[RED("forceOpenDuringFadeout")] 
		public CBool ForceOpenDuringFadeout
		{
			get => GetProperty(ref _forceOpenDuringFadeout);
			set => SetProperty(ref _forceOpenDuringFadeout, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CluePSData : IScriptable
	{
		private CInt32 _id;
		private CBool _isEnabled;
		private CBool _wasInspected;
		private CBool _isScanned;
		private CEnum<EConclusionQuestState> _conclusionQuestState;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(2)] 
		[RED("wasInspected")] 
		public CBool WasInspected
		{
			get => GetProperty(ref _wasInspected);
			set => SetProperty(ref _wasInspected, value);
		}

		[Ordinal(3)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetProperty(ref _isScanned);
			set => SetProperty(ref _isScanned, value);
		}

		[Ordinal(4)] 
		[RED("conclusionQuestState")] 
		public CEnum<EConclusionQuestState> ConclusionQuestState
		{
			get => GetProperty(ref _conclusionQuestState);
			set => SetProperty(ref _conclusionQuestState, value);
		}
	}
}

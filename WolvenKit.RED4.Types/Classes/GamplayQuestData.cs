using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GamplayQuestData : IScriptable
	{
		private CString _questUniqueID;
		private CArray<CHandle<GemplayObjectiveData>> _objectives;

		[Ordinal(0)] 
		[RED("questUniqueID")] 
		public CString QuestUniqueID
		{
			get => GetProperty(ref _questUniqueID);
			set => SetProperty(ref _questUniqueID, value);
		}

		[Ordinal(1)] 
		[RED("objectives")] 
		public CArray<CHandle<GemplayObjectiveData>> Objectives
		{
			get => GetProperty(ref _objectives);
			set => SetProperty(ref _objectives, value);
		}
	}
}

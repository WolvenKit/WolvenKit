using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GamplayQuestData : IScriptable
	{
		[Ordinal(0)] 
		[RED("questUniqueID")] 
		public CString QuestUniqueID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("objectives")] 
		public CArray<CHandle<GemplayObjectiveData>> Objectives
		{
			get => GetPropertyValue<CArray<CHandle<GemplayObjectiveData>>>();
			set => SetPropertyValue<CArray<CHandle<GemplayObjectiveData>>>(value);
		}

		public GamplayQuestData()
		{
			Objectives = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

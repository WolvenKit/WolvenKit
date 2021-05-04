using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GamplayQuestData : IScriptable
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

		public GamplayQuestData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

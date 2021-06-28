using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticQuestMarkerNode : worldNode
	{
		private CEnum<worldQuestType> _questType;
		private CString _questLabel;
		private CFloat _questMarkerHeight;

		[Ordinal(4)] 
		[RED("questType")] 
		public CEnum<worldQuestType> QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}

		[Ordinal(5)] 
		[RED("questLabel")] 
		public CString QuestLabel
		{
			get => GetProperty(ref _questLabel);
			set => SetProperty(ref _questLabel, value);
		}

		[Ordinal(6)] 
		[RED("questMarkerHeight")] 
		public CFloat QuestMarkerHeight
		{
			get => GetProperty(ref _questMarkerHeight);
			set => SetProperty(ref _questMarkerHeight, value);
		}

		public worldStaticQuestMarkerNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

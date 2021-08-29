using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldStaticQuestMarkerNode : worldNode
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
	}
}

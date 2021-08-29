using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestListHeaderClicked : redEvent
	{
		private CInt32 _questType;

		[Ordinal(0)] 
		[RED("questType")] 
		public CInt32 QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}
	}
}

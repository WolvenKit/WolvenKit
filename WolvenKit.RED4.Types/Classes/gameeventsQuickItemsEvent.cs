using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsQuickItemsEvent : redEvent
	{
		private CName _questName;

		[Ordinal(0)] 
		[RED("questName")] 
		public CName QuestName
		{
			get => GetProperty(ref _questName);
			set => SetProperty(ref _questName, value);
		}
	}
}

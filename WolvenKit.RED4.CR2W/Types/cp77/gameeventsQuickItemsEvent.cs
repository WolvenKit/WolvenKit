using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsQuickItemsEvent : redEvent
	{
		private CName _questName;

		[Ordinal(0)] 
		[RED("questName")] 
		public CName QuestName
		{
			get => GetProperty(ref _questName);
			set => SetProperty(ref _questName, value);
		}

		public gameeventsQuickItemsEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

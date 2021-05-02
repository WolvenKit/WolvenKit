using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackDataEvent : redEvent
	{
		private CHandle<QuickhackData> _selectedData;

		[Ordinal(0)] 
		[RED("selectedData")] 
		public CHandle<QuickhackData> SelectedData
		{
			get => GetProperty(ref _selectedData);
			set => SetProperty(ref _selectedData, value);
		}

		public QuickHackDataEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

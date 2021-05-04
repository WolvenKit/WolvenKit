using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class panelApperanceSwitchEvent : redEvent
	{
		private CName _newApperance;

		[Ordinal(0)] 
		[RED("newApperance")] 
		public CName NewApperance
		{
			get => GetProperty(ref _newApperance);
			set => SetProperty(ref _newApperance, value);
		}

		public panelApperanceSwitchEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

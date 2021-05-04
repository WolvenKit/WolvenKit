using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestCrystalDomeEvent : redEvent
	{
		private CBool _toggle;
		private CBool _removeQuestControl;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("removeQuestControl")] 
		public CBool RemoveQuestControl
		{
			get => GetProperty(ref _removeQuestControl);
			set => SetProperty(ref _removeQuestControl, value);
		}

		public VehicleQuestCrystalDomeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

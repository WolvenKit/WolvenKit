using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlideEvents : CrouchEvents
	{
		private CBool _rumblePlayed;
		private CHandle<gameStatModifierData> _addDecelerationModifier;

		[Ordinal(0)] 
		[RED("rumblePlayed")] 
		public CBool RumblePlayed
		{
			get => GetProperty(ref _rumblePlayed);
			set => SetProperty(ref _rumblePlayed, value);
		}

		[Ordinal(1)] 
		[RED("addDecelerationModifier")] 
		public CHandle<gameStatModifierData> AddDecelerationModifier
		{
			get => GetProperty(ref _addDecelerationModifier);
			set => SetProperty(ref _addDecelerationModifier, value);
		}

		public SlideEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

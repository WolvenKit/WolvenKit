using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersData : CVariable
	{
		private CEnum<EWindowBlindersStates> _windowBlindersState;
		private CBool _hasOpenInteraction;
		private CBool _hasTiltInteraction;
		private CBool _hasQuickHack;

		[Ordinal(0)] 
		[RED("windowBlindersState")] 
		public CEnum<EWindowBlindersStates> WindowBlindersState
		{
			get => GetProperty(ref _windowBlindersState);
			set => SetProperty(ref _windowBlindersState, value);
		}

		[Ordinal(1)] 
		[RED("hasOpenInteraction")] 
		public CBool HasOpenInteraction
		{
			get => GetProperty(ref _hasOpenInteraction);
			set => SetProperty(ref _hasOpenInteraction, value);
		}

		[Ordinal(2)] 
		[RED("hasTiltInteraction")] 
		public CBool HasTiltInteraction
		{
			get => GetProperty(ref _hasTiltInteraction);
			set => SetProperty(ref _hasTiltInteraction, value);
		}

		[Ordinal(3)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get => GetProperty(ref _hasQuickHack);
			set => SetProperty(ref _hasQuickHack, value);
		}

		public WindowBlindersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

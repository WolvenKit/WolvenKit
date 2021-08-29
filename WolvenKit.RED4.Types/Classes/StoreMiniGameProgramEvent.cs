using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StoreMiniGameProgramEvent : redEvent
	{
		private gameuiMinigameProgramData _program;
		private CBool _add;

		[Ordinal(0)] 
		[RED("program")] 
		public gameuiMinigameProgramData Program
		{
			get => GetProperty(ref _program);
			set => SetProperty(ref _program, value);
		}

		[Ordinal(1)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetProperty(ref _add);
			set => SetProperty(ref _add, value);
		}
	}
}

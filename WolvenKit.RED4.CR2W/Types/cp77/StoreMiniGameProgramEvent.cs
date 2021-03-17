using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StoreMiniGameProgramEvent : redEvent
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

		public StoreMiniGameProgramEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

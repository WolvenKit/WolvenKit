using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetQuickHackableMask : redEvent
	{
		private CBool _isQuickHackable;

		[Ordinal(0)] 
		[RED("isQuickHackable")] 
		public CBool IsQuickHackable
		{
			get => GetProperty(ref _isQuickHackable);
			set => SetProperty(ref _isQuickHackable, value);
		}

		public gameSetQuickHackableMask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

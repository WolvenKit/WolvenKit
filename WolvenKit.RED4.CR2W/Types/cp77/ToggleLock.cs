using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleLock : ActionBool
	{
		private CBool _shouldOpen;

		[Ordinal(25)] 
		[RED("shouldOpen")] 
		public CBool ShouldOpen
		{
			get => GetProperty(ref _shouldOpen);
			set => SetProperty(ref _shouldOpen, value);
		}

		public ToggleLock(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

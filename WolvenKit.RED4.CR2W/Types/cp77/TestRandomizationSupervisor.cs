using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		private CBool _firstWasGenerated;

		[Ordinal(0)] 
		[RED("firstWasGenerated")] 
		public CBool FirstWasGenerated
		{
			get => GetProperty(ref _firstWasGenerated);
			set => SetProperty(ref _firstWasGenerated, value);
		}

		public TestRandomizationSupervisor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

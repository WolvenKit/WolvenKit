using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestRandomizationSupervisor : genScriptedRandomizationSupervisor
	{
		private CBool _firstWasGenerated;

		[Ordinal(0)] 
		[RED("firstWasGenerated")] 
		public CBool FirstWasGenerated
		{
			get => GetProperty(ref _firstWasGenerated);
			set => SetProperty(ref _firstWasGenerated, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkPhaseAnim : animAnimNode_SkAnim
	{
		private CName _phase;

		[Ordinal(30)] 
		[RED("phase")] 
		public CName Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}
	}
}

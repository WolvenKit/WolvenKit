using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeakFenceSetup : RedBaseClass
	{
		private CBool _hasGenericInteraction;

		[Ordinal(0)] 
		[RED("hasGenericInteraction")] 
		public CBool HasGenericInteraction
		{
			get => GetProperty(ref _hasGenericInteraction);
			set => SetProperty(ref _hasGenericInteraction, value);
		}
	}
}

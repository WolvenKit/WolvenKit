using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TemporaryUnequipEvents : UpperBodyEventsTransition
	{
		private CBool _forceOpen;

		[Ordinal(6)] 
		[RED("forceOpen")] 
		public CBool ForceOpen
		{
			get => GetProperty(ref _forceOpen);
			set => SetProperty(ref _forceOpen, value);
		}
	}
}

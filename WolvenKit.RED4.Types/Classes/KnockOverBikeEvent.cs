using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class KnockOverBikeEvent : redEvent
	{
		private CBool _forceKnockdown;
		private CBool _applyDirectionalForce;

		[Ordinal(0)] 
		[RED("forceKnockdown")] 
		public CBool ForceKnockdown
		{
			get => GetProperty(ref _forceKnockdown);
			set => SetProperty(ref _forceKnockdown, value);
		}

		[Ordinal(1)] 
		[RED("applyDirectionalForce")] 
		public CBool ApplyDirectionalForce
		{
			get => GetProperty(ref _applyDirectionalForce);
			set => SetProperty(ref _applyDirectionalForce, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ReprimandEscalationEvent : redEvent
	{
		private CBool _startReprimand;
		private CBool _startDeescalate;

		[Ordinal(0)] 
		[RED("startReprimand")] 
		public CBool StartReprimand
		{
			get => GetProperty(ref _startReprimand);
			set => SetProperty(ref _startReprimand, value);
		}

		[Ordinal(1)] 
		[RED("startDeescalate")] 
		public CBool StartDeescalate
		{
			get => GetProperty(ref _startDeescalate);
			set => SetProperty(ref _startDeescalate, value);
		}
	}
}

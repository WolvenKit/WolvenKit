using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyObjectActionEffector : gameEffector
	{
		private TweakDBID _actionID;
		private CBool _triggered;
		private CFloat _probability;

		[Ordinal(0)] 
		[RED("actionID")] 
		public TweakDBID ActionID
		{
			get => GetProperty(ref _actionID);
			set => SetProperty(ref _actionID, value);
		}

		[Ordinal(1)] 
		[RED("triggered")] 
		public CBool Triggered
		{
			get => GetProperty(ref _triggered);
			set => SetProperty(ref _triggered, value);
		}

		[Ordinal(2)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}
	}
}

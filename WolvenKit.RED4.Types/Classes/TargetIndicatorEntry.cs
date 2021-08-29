using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetIndicatorEntry : RedBaseClass
	{
		private entEntityID _targetID;
		private CWeakHandle<inkWidget> _indicator;

		[Ordinal(0)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(1)] 
		[RED("indicator")] 
		public CWeakHandle<inkWidget> Indicator
		{
			get => GetProperty(ref _indicator);
			set => SetProperty(ref _indicator, value);
		}
	}
}

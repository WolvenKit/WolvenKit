using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<SensorDevice> _lsitener;
		private CWeakHandle<gameObject> _lsitenTarget;

		[Ordinal(0)] 
		[RED("lsitener")] 
		public CWeakHandle<SensorDevice> Lsitener
		{
			get => GetProperty(ref _lsitener);
			set => SetProperty(ref _lsitener, value);
		}

		[Ordinal(1)] 
		[RED("lsitenTarget")] 
		public CWeakHandle<gameObject> LsitenTarget
		{
			get => GetProperty(ref _lsitenTarget);
			set => SetProperty(ref _lsitenTarget, value);
		}
	}
}

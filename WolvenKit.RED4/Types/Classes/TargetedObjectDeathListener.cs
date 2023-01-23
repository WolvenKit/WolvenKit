using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetedObjectDeathListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("lsitener")] 
		public CWeakHandle<SensorDevice> Lsitener
		{
			get => GetPropertyValue<CWeakHandle<SensorDevice>>();
			set => SetPropertyValue<CWeakHandle<SensorDevice>>(value);
		}

		[Ordinal(1)] 
		[RED("lsitenTarget")] 
		public CWeakHandle<gameObject> LsitenTarget
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public TargetedObjectDeathListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplicatedShotData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeStamp")] 
		public netTime TimeStamp
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		[Ordinal(1)] 
		[RED("attackId")] 
		public TweakDBID AttackId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("targetLocalOffset")] 
		public Vector3 TargetLocalOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public gameReplicatedShotData()
		{
			TimeStamp = new netTime { MilliSecs = long.MaxValue };
			TargetLocalOffset = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

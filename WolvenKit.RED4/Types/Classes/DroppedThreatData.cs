using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DroppedThreatData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("threat")] 
		public CWeakHandle<entEntity> Threat
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("timeStamp")] 
		public CFloat TimeStamp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public DroppedThreatData()
		{
			Position = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamesmartGunUITargetParameters : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("pos")] 
		public Vector2 Pos
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<gamesmartGunTargetState> State
		{
			get => GetPropertyValue<CEnum<gamesmartGunTargetState>>();
			set => SetPropertyValue<CEnum<gamesmartGunTargetState>>(value);
		}

		[Ordinal(2)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("accuracy")] 
		public CFloat Accuracy
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("timeLocking")] 
		public CFloat TimeLocking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeUnlocking")] 
		public CFloat TimeUnlocking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("timeOccluded")] 
		public CFloat TimeOccluded
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gamesmartGunUITargetParameters()
		{
			Pos = new Vector2();
			EntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

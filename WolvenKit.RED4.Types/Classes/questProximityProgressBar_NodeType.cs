using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questProximityProgressBar_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("reset")] 
		public CBool Reset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("distanceComparisonType")] 
		public CEnum<EComparisonType> DistanceComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(5)] 
		[RED("target")] 
		public gameEntityReference Target
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(6)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("activator")] 
		public gameEntityReference Activator
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		public questProximityProgressBar_NodeType()
		{
			Show = true;
			Duration = 10.000000F;
			Reset = true;
			Distance = 10.000000F;
			DistanceComparisonType = Enums.EComparisonType.Less;
			Target = new() { Names = new() };
			IsPlayerActivator = true;
			Activator = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

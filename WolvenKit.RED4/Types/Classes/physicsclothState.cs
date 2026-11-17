using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsclothState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("verticalPhaseData")] 
		public physicsclothPhaseConfig VerticalPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(1)] 
		[RED("horizontalPhaseData")] 
		public physicsclothPhaseConfig HorizontalPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(2)] 
		[RED("bendPhaseData")] 
		public physicsclothPhaseConfig BendPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(3)] 
		[RED("shearPhaseData")] 
		public physicsclothPhaseConfig ShearPhaseData
		{
			get => GetPropertyValue<physicsclothPhaseConfig>();
			set => SetPropertyValue<physicsclothPhaseConfig>(value);
		}

		[Ordinal(4)] 
		[RED("runtimeInfo")] 
		public physicsclothRuntimeInfo RuntimeInfo
		{
			get => GetPropertyValue<physicsclothRuntimeInfo>();
			set => SetPropertyValue<physicsclothRuntimeInfo>(value);
		}

		public physicsclothState()
		{
			VerticalPhaseData = new physicsclothPhaseConfig();
			HorizontalPhaseData = new physicsclothPhaseConfig();
			BendPhaseData = new physicsclothPhaseConfig();
			ShearPhaseData = new physicsclothPhaseConfig();
			RuntimeInfo = new physicsclothRuntimeInfo();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AISpotPersistentData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("worldPosition")] 
		public WorldPosition WorldPosition
		{
			get => GetPropertyValue<WorldPosition>();
			set => SetPropertyValue<WorldPosition>(value);
		}

		[Ordinal(1)] 
		[RED("globalNodeId")] 
		public worldGlobalNodeID GlobalNodeId
		{
			get => GetPropertyValue<worldGlobalNodeID>();
			set => SetPropertyValue<worldGlobalNodeID>(value);
		}

		[Ordinal(2)] 
		[RED("yaw")] 
		public CFloat Yaw
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AISpotPersistentData()
		{
			WorldPosition = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() };
			GlobalNodeId = new worldGlobalNodeID();
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entAmbientSoundEmitterComponent : entIPlacedComponent
	{
		[Ordinal(5)] 
		[RED("Settings")] 
		public CHandle<audioAmbientAreaSettings> Settings
		{
			get => GetPropertyValue<CHandle<audioAmbientAreaSettings>>();
			set => SetPropertyValue<CHandle<audioAmbientAreaSettings>>(value);
		}

		[Ordinal(6)] 
		[RED("usePhysicsObstruction")] 
		public CBool UsePhysicsObstruction
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("occlusionEnabled")] 
		public CBool OcclusionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("repositionEnabled")] 
		public CBool RepositionEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("obstructionChangeTime")] 
		public CFloat ObstructionChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entAmbientSoundEmitterComponent()
		{
			Name = "Component";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

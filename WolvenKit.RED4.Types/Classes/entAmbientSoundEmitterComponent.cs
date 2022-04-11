using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
		}
	}
}

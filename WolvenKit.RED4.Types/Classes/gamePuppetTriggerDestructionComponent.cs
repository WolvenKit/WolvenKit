using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePuppetTriggerDestructionComponent : gameITriggerDestructionComponent
	{
		[Ordinal(4)] 
		[RED("projectionDist")] 
		public CFloat ProjectionDist
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamePuppetTriggerDestructionComponent()
		{
			Name = "Component";
			StartActive = true;
		}
	}
}

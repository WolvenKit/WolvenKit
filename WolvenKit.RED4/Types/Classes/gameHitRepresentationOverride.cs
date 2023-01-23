using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitRepresentationOverride : ISerializable
	{
		[Ordinal(0)] 
		[RED("represenationOverride")] 
		public gameHitShapeContainer RepresenationOverride
		{
			get => GetPropertyValue<gameHitShapeContainer>();
			set => SetPropertyValue<gameHitShapeContainer>(value);
		}

		public gameHitRepresentationOverride()
		{
			RepresenationOverride = new() { Color = new(), PhysicsMaterial = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

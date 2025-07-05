using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsCollisionPresetsOverridesResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<physicsCollisionPresetOverride> Overrides
		{
			get => GetPropertyValue<CArray<physicsCollisionPresetOverride>>();
			set => SetPropertyValue<CArray<physicsCollisionPresetOverride>>(value);
		}

		public physicsCollisionPresetsOverridesResource()
		{
			Overrides = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionPresetsResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsCollisionPresetDefinition> Presets
		{
			get => GetPropertyValue<CArray<physicsCollisionPresetDefinition>>();
			set => SetPropertyValue<CArray<physicsCollisionPresetDefinition>>(value);
		}

		public physicsCollisionPresetsResource()
		{
			Presets = new();
		}
	}
}

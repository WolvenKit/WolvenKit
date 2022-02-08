using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionPresetsResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsCollisionPreset> Presets
		{
			get => GetPropertyValue<CArray<physicsCollisionPreset>>();
			set => SetPropertyValue<CArray<physicsCollisionPreset>>(value);
		}

		public physicsCollisionPresetsResource()
		{
			Presets = new();
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class physicsQueryPresetResource : ISerializable
	{
		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsQueryPresetDefinition> Presets
		{
			get => GetPropertyValue<CArray<physicsQueryPresetDefinition>>();
			set => SetPropertyValue<CArray<physicsQueryPresetDefinition>>(value);
		}

		public physicsQueryPresetResource()
		{
			Presets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionPresetsResource : ISerializable
	{
		private CArray<physicsCollisionPreset> _presets;

		[Ordinal(0)] 
		[RED("presets")] 
		public CArray<physicsCollisionPreset> Presets
		{
			get => GetProperty(ref _presets);
			set => SetProperty(ref _presets, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class physicsCollisionPresetsOverridesResource : ISerializable
	{
		private CArray<physicsCollisionPresetOverride> _overrides;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<physicsCollisionPresetOverride> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}
	}
}

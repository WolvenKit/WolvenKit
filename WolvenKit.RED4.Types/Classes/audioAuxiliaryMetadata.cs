using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAuxiliaryMetadata : RedBaseClass
	{
		private CName _physicalPropSettings;

		[Ordinal(0)] 
		[RED("physicalPropSettings")] 
		public CName PhysicalPropSettings
		{
			get => GetProperty(ref _physicalPropSettings);
			set => SetProperty(ref _physicalPropSettings, value);
		}
	}
}

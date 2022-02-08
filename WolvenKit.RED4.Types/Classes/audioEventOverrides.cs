using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioEventOverrides : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("eventOverrides")] 
		public CHandle<audioEventOverrideDictionary> EventOverrides
		{
			get => GetPropertyValue<CHandle<audioEventOverrideDictionary>>();
			set => SetPropertyValue<CHandle<audioEventOverrideDictionary>>(value);
		}
	}
}

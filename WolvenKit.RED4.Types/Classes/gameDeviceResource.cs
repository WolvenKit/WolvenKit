using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameDeviceResourceData> Data
		{
			get => GetPropertyValue<CHandle<gameDeviceResourceData>>();
			set => SetPropertyValue<CHandle<gameDeviceResourceData>>(value);
		}
	}
}

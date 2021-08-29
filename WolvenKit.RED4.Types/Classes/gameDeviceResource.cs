using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceResource : CResource
	{
		private CHandle<gameDeviceResourceData> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameDeviceResourceData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}

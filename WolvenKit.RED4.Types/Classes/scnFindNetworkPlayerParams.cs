using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnFindNetworkPlayerParams : RedBaseClass
	{
		private CUInt32 _networkId;

		[Ordinal(0)] 
		[RED("networkId")] 
		public CUInt32 NetworkId
		{
			get => GetProperty(ref _networkId);
			set => SetProperty(ref _networkId, value);
		}
	}
}

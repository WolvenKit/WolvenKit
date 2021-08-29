using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDistantLightsNode : worldNode
	{
		private CResourceAsyncReference<CDistantLightsResource> _data;

		[Ordinal(4)] 
		[RED("data")] 
		public CResourceAsyncReference<CDistantLightsResource> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}

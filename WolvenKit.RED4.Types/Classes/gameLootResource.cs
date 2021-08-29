using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootResource : CResource
	{
		private CHandle<gameLootResourceData> _data;

		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameLootResourceData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}

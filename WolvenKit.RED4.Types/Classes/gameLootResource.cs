using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLootResource : CResource
	{
		[Ordinal(1)] 
		[RED("data")] 
		public CHandle<gameLootResourceData> Data
		{
			get => GetPropertyValue<CHandle<gameLootResourceData>>();
			set => SetPropertyValue<CHandle<gameLootResourceData>>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldBlockoutResource : CResource
	{
		[Ordinal(1)] 
		[RED("blockoutData")] 
		public CHandle<worldBlockoutData> BlockoutData
		{
			get => GetPropertyValue<CHandle<worldBlockoutData>>();
			set => SetPropertyValue<CHandle<worldBlockoutData>>(value);
		}
	}
}

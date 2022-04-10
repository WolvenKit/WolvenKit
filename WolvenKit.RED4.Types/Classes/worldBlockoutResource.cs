using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldBlockoutResource : CResource
	{
		[Ordinal(1)] 
		[RED("blockoutData")] 
		public CHandle<worldBlockoutData> BlockoutData
		{
			get => GetPropertyValue<CHandle<worldBlockoutData>>();
			set => SetPropertyValue<CHandle<worldBlockoutData>>(value);
		}

		public worldBlockoutResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

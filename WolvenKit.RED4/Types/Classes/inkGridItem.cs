using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkGridItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rootIdx")] 
		public CUInt32 RootIdx
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public inkGridItem()
		{
			RootIdx = 4294967295;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

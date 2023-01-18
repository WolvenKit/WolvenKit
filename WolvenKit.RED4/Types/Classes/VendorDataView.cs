using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorDataView : BackpackDataView
	{
		[Ordinal(4)] 
		[RED("isVendorGrid")] 
		public CBool IsVendorGrid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("openTime")] 
		public GameTime OpenTime
		{
			get => GetPropertyValue<GameTime>();
			set => SetPropertyValue<GameTime>(value);
		}

		public VendorDataView()
		{
			OpenTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

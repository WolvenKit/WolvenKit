using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopSelectionChangeInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("selected")] 
		public CArray<CUInt64> Selected
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		[Ordinal(1)] 
		[RED("deselected")] 
		public CArray<CUInt64> Deselected
		{
			get => GetPropertyValue<CArray<CUInt64>>();
			set => SetPropertyValue<CArray<CUInt64>>(value);
		}

		public interopSelectionChangeInfo()
		{
			Selected = new();
			Deselected = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

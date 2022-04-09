using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CComStaticSkeletonData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CComStaticSkeletonDataEntry> Entries
		{
			get => GetPropertyValue<CArray<CComStaticSkeletonDataEntry>>();
			set => SetPropertyValue<CArray<CComStaticSkeletonDataEntry>>(value);
		}

		public CComStaticSkeletonData()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

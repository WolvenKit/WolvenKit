using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameWrappedEntIDArray : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("arr")] 
		public CArray<entEntityID> Arr
		{
			get => GetPropertyValue<CArray<entEntityID>>();
			set => SetPropertyValue<CArray<entEntityID>>(value);
		}

		public gameWrappedEntIDArray()
		{
			Arr = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

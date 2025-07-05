using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAnimsetOverrideData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animsetHash")] 
		public CUInt64 AnimsetHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("variables")] 
		public CArray<CName> Variables
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public gameAnimsetOverrideData()
		{
			Variables = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

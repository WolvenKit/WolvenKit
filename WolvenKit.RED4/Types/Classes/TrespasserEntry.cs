using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrespasserEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("trespasser")] 
		public CWeakHandle<gameObject> Trespasser
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("isScanned")] 
		public CBool IsScanned
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isInsideA")] 
		public CBool IsInsideA
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("isInsideB")] 
		public CBool IsInsideB
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("isInsideScanner")] 
		public CBool IsInsideScanner
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("areaStack")] 
		public CArray<CName> AreaStack
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public TrespasserEntry()
		{
			AreaStack = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

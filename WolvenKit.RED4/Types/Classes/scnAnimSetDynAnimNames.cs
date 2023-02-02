using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAnimSetDynAnimNames : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animVariable", 1)] 
		public CStatic<CName> AnimVariable
		{
			get => GetPropertyValue<CStatic<CName>>();
			set => SetPropertyValue<CStatic<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("animNames")] 
		public CArray<CName> AnimNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public scnAnimSetDynAnimNames()
		{
			AnimVariable = new(0);
			AnimNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

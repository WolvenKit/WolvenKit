using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class senseShapes : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("shapes")] 
		public CArray<CHandle<senseIShape>> Shapes
		{
			get => GetPropertyValue<CArray<CHandle<senseIShape>>>();
			set => SetPropertyValue<CArray<CHandle<senseIShape>>>(value);
		}

		public senseShapes()
		{
			Shapes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

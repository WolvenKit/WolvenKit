using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class Box : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Min")] 
		public Vector4 Min
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("Max")] 
		public Vector4 Max
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public Box()
		{
			Min = new Vector4();
			Max = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

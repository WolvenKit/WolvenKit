using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class ConvexHull : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("planes")] 
		public CArray<Vector4> Planes
		{
			get => GetPropertyValue<CArray<Vector4>>();
			set => SetPropertyValue<CArray<Vector4>>(value);
		}

		public ConvexHull()
		{
			Planes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AreaShapeOutline : ISerializable
	{
		[Ordinal(0)] 
		[RED("points")] 
		public CArray<Vector3> Points
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}

		[Ordinal(1)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AreaShapeOutline()
		{
			Points = new() { new Vector3 { X = -1.000000F, Y = -1.000000F }, new Vector3 { X = 1.000000F, Y = -1.000000F }, new Vector3 { X = 1.000000F, Y = 1.000000F }, new Vector3 { X = -1.000000F, Y = 1.000000F } };
			Height = 2.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

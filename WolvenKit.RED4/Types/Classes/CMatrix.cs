using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	[RED("Matrix")]
	public partial class CMatrix : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("X")] 
		public Vector4 X
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("Y")] 
		public Vector4 Y
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("Z")] 
		public Vector4 Z
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(3)] 
		[RED("W")] 
		public Vector4 W
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public CMatrix()
		{
			X = new Vector4 { X = 1.000000F };
			Y = new Vector4 { Y = 1.000000F };
			Z = new Vector4 { Z = 1.000000F };
			W = new Vector4 { W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

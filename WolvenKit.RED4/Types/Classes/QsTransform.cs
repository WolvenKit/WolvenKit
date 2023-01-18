using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class QsTransform : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Translation")] 
		public Vector4 Translation
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("Rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("Scale")] 
		public Vector4 Scale
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public QsTransform()
		{
			Translation = new();
			Rotation = new() { R = 1.000000F };
			Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

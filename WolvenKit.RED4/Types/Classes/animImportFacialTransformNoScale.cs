using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialTransformNoScale : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(1)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public animImportFacialTransformNoScale()
		{
			Rotation = new Quaternion { R = 1.000000F };
			Translation = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

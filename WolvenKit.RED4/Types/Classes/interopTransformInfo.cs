using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopTransformInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("translation")] 
		public Vector3 Translation
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public EulerAngles Rotation
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		public interopTransformInfo()
		{
			Translation = new();
			Rotation = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

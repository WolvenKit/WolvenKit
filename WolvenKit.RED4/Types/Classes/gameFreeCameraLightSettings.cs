using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameFreeCameraLightSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("s")] 
		public Vector3 S
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("tensity")] 
		public CFloat Tensity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("mperature")] 
		public CFloat Mperature
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("lor")] 
		public Vector4 Lor
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public gameFreeCameraLightSettings()
		{
			S = new Vector3();
			Lor = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class attrMinMaxVector3 : attrAttribute
	{
		[Ordinal(0)] 
		[RED("n")] 
		public Vector3 N
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("x")] 
		public Vector3 X
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		public attrMinMaxVector3()
		{
			N = new Vector3();
			X = new Vector3();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

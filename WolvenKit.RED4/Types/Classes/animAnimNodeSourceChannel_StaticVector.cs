using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNodeSourceChannel_StaticVector : animIAnimNodeSourceChannel_Vector
	{
		[Ordinal(0)] 
		[RED("data")] 
		public Vector4 Data
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimNodeSourceChannel_StaticVector()
		{
			Data = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

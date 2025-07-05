using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineparameterTypeAdjustTransform : IScriptable
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		public gamestateMachineparameterTypeAdjustTransform()
		{
			Position = new Vector4 { W = 1.000000F };
			Rotation = new Quaternion { R = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

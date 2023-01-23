using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameHitShapeBase : gameIHitShape
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
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(2)] 
		[RED("localTransform")] 
		public CMatrix LocalTransform
		{
			get => GetPropertyValue<CMatrix>();
			set => SetPropertyValue<CMatrix>(value);
		}

		public gameHitShapeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

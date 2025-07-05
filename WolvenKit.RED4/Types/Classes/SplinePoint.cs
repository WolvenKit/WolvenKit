using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SplinePoint : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("position")] 
		public Vector3 Position
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
		[RED("tangents", 2)] 
		public CArrayFixedSize<Vector3> Tangents
		{
			get => GetPropertyValue<CArrayFixedSize<Vector3>>();
			set => SetPropertyValue<CArrayFixedSize<Vector3>>(value);
		}

		[Ordinal(3)] 
		[RED("continuousTangents")] 
		public CBool ContinuousTangents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("automaticTangents")] 
		public CBool AutomaticTangents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public SplinePoint()
		{
			Position = new Vector3();
			Rotation = new Quaternion { R = 1.000000F };
			Tangents = new(2);
			ContinuousTangents = true;
			AutomaticTangents = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

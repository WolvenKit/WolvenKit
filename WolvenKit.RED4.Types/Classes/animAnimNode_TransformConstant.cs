using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformConstant : animAnimNode_TransformValue
	{
		[Ordinal(11)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(12)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetPropertyValue<Quaternion>();
			set => SetPropertyValue<Quaternion>(value);
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimNode_TransformConstant()
		{
			Id = 4294967295;
			Pos = new() { W = 1.000000F };
			Rotation = new() { R = 1.000000F };
			Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F };
		}
	}
}

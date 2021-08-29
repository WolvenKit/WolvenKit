using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformConstant : animAnimNode_TransformValue
	{
		private Vector4 _pos;
		private Quaternion _rotation;
		private Vector4 _scale;

		[Ordinal(11)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(12)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(13)] 
		[RED("scale")] 
		public Vector4 Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}
	}
}

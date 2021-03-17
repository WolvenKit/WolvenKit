using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_SimpleIkSystem : animAnimFeature
	{
		private CBool _isEnable;
		private CFloat _weight;
		private CBool _setPosition;
		private Vector4 _position;
		private Vector4 _positionOffset;
		private CBool _setRotation;
		private Quaternion _rotation;
		private Quaternion _rotationOffset;

		[Ordinal(0)] 
		[RED("isEnable")] 
		public CBool IsEnable
		{
			get => GetProperty(ref _isEnable);
			set => SetProperty(ref _isEnable, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(2)] 
		[RED("setPosition")] 
		public CBool SetPosition
		{
			get => GetProperty(ref _setPosition);
			set => SetProperty(ref _setPosition, value);
		}

		[Ordinal(3)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(4)] 
		[RED("positionOffset")] 
		public Vector4 PositionOffset
		{
			get => GetProperty(ref _positionOffset);
			set => SetProperty(ref _positionOffset, value);
		}

		[Ordinal(5)] 
		[RED("setRotation")] 
		public CBool SetRotation
		{
			get => GetProperty(ref _setRotation);
			set => SetProperty(ref _setRotation, value);
		}

		[Ordinal(6)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}

		[Ordinal(7)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetProperty(ref _rotationOffset);
			set => SetProperty(ref _rotationOffset, value);
		}

		public AnimFeature_SimpleIkSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

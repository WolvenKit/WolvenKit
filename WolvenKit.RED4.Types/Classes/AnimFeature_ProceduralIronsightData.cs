using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_ProceduralIronsightData : animAnimFeature
	{
		private CBool _hasScope;
		private CBool _isEnabled;
		private CFloat _offset;
		private CFloat _scopeOffset;
		private Vector4 _position;
		private Quaternion _rotation;

		[Ordinal(0)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetProperty(ref _hasScope);
			set => SetProperty(ref _hasScope, value);
		}

		[Ordinal(1)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("scopeOffset")] 
		public CFloat ScopeOffset
		{
			get => GetProperty(ref _scopeOffset);
			set => SetProperty(ref _scopeOffset, value);
		}

		[Ordinal(4)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(5)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get => GetProperty(ref _rotation);
			set => SetProperty(ref _rotation, value);
		}
	}
}

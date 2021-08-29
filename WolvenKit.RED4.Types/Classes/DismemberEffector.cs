using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DismemberEffector : gameEffector
	{
		private CName _bodyPart;
		private CName _woundType;
		private Vector3 _hitPosition;
		private CBool _isCritical;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CName WoundType
		{
			get => GetProperty(ref _woundType);
			set => SetProperty(ref _woundType, value);
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector3 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(3)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetProperty(ref _isCritical);
			set => SetProperty(ref _isCritical, value);
		}
	}
}

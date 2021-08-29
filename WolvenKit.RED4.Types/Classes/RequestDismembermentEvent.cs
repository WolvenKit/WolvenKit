using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestDismembermentEvent : AIAIEvent
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _dismembermentType;
		private Vector4 _hitPosition;
		private CBool _isCritical;

		[Ordinal(2)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(3)] 
		[RED("dismembermentType")] 
		public CEnum<gameDismWoundType> DismembermentType
		{
			get => GetProperty(ref _dismembermentType);
			set => SetProperty(ref _dismembermentType, value);
		}

		[Ordinal(4)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(5)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get => GetProperty(ref _isCritical);
			set => SetProperty(ref _isCritical, value);
		}
	}
}

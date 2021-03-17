using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactionsData : animAnimFeature
	{
		private CInt32 _hitIntensity;
		private CInt32 _hitSource;
		private CInt32 _hitType;
		private CInt32 _hitBodyPart;
		private CInt32 _npcMovementSpeed;
		private CInt32 _hitDirection;
		private CInt32 _npcMovementDirection;
		private CInt32 _stance;
		private CInt32 _animVariation;
		private CBool _useInitialRotation;
		private Vector4 _hitDirectionWs;
		private CFloat _angleToAttack;
		private CFloat _initialRotationDuration;

		[Ordinal(0)] 
		[RED("hitIntensity")] 
		public CInt32 HitIntensity
		{
			get => GetProperty(ref _hitIntensity);
			set => SetProperty(ref _hitIntensity, value);
		}

		[Ordinal(1)] 
		[RED("hitSource")] 
		public CInt32 HitSource
		{
			get => GetProperty(ref _hitSource);
			set => SetProperty(ref _hitSource, value);
		}

		[Ordinal(2)] 
		[RED("hitType")] 
		public CInt32 HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(3)] 
		[RED("hitBodyPart")] 
		public CInt32 HitBodyPart
		{
			get => GetProperty(ref _hitBodyPart);
			set => SetProperty(ref _hitBodyPart, value);
		}

		[Ordinal(4)] 
		[RED("npcMovementSpeed")] 
		public CInt32 NpcMovementSpeed
		{
			get => GetProperty(ref _npcMovementSpeed);
			set => SetProperty(ref _npcMovementSpeed, value);
		}

		[Ordinal(5)] 
		[RED("hitDirection")] 
		public CInt32 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(6)] 
		[RED("npcMovementDirection")] 
		public CInt32 NpcMovementDirection
		{
			get => GetProperty(ref _npcMovementDirection);
			set => SetProperty(ref _npcMovementDirection, value);
		}

		[Ordinal(7)] 
		[RED("stance")] 
		public CInt32 Stance
		{
			get => GetProperty(ref _stance);
			set => SetProperty(ref _stance, value);
		}

		[Ordinal(8)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(9)] 
		[RED("useInitialRotation")] 
		public CBool UseInitialRotation
		{
			get => GetProperty(ref _useInitialRotation);
			set => SetProperty(ref _useInitialRotation, value);
		}

		[Ordinal(10)] 
		[RED("hitDirectionWs")] 
		public Vector4 HitDirectionWs
		{
			get => GetProperty(ref _hitDirectionWs);
			set => SetProperty(ref _hitDirectionWs, value);
		}

		[Ordinal(11)] 
		[RED("angleToAttack")] 
		public CFloat AngleToAttack
		{
			get => GetProperty(ref _angleToAttack);
			set => SetProperty(ref _angleToAttack, value);
		}

		[Ordinal(12)] 
		[RED("initialRotationDuration")] 
		public CFloat InitialRotationDuration
		{
			get => GetProperty(ref _initialRotationDuration);
			set => SetProperty(ref _initialRotationDuration, value);
		}

		public animAnimFeature_HitReactionsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

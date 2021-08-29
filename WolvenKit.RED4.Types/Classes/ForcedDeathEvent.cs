using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ForcedDeathEvent : redEvent
	{
		private CInt32 _hitIntensity;
		private CInt32 _hitSource;
		private CInt32 _hitType;
		private CInt32 _hitBodyPart;
		private CInt32 _hitNpcMovementSpeed;
		private CInt32 _hitDirection;
		private CInt32 _hitNpcMovementDirection;
		private CBool _forceRagdoll;

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
		[RED("hitNpcMovementSpeed")] 
		public CInt32 HitNpcMovementSpeed
		{
			get => GetProperty(ref _hitNpcMovementSpeed);
			set => SetProperty(ref _hitNpcMovementSpeed, value);
		}

		[Ordinal(5)] 
		[RED("hitDirection")] 
		public CInt32 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(6)] 
		[RED("hitNpcMovementDirection")] 
		public CInt32 HitNpcMovementDirection
		{
			get => GetProperty(ref _hitNpcMovementDirection);
			set => SetProperty(ref _hitNpcMovementDirection, value);
		}

		[Ordinal(7)] 
		[RED("forceRagdoll")] 
		public CBool ForceRagdoll
		{
			get => GetProperty(ref _forceRagdoll);
			set => SetProperty(ref _forceRagdoll, value);
		}
	}
}

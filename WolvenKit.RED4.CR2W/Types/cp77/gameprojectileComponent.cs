using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameprojectileComponent : entIPlacedComponent
	{
		private CEnum<gameprojectileOnCollisionAction> _onCollisionAction;
		private CBool _useSweepCollision;
		private CBool _collisionsFilterClosest;
		private CFloat _sweepCollisionRadius;
		private Quaternion _rotationOffset;
		private CBool _deriveOwnerVelocity;
		private gameprojectileVelocityParams _derivedVelocityParams;
		private CHandle<physicsFilterData> _filterData;
		private raRef<worldEffect> _previewEffect;
		private raRef<worldEffect> _bouncePreviewEffect;
		private raRef<worldEffect> _explosionPreviewEffect;
		private CFloat _explosionPreviewTime;
		private gameEffectRef _gameEffectRef;

		[Ordinal(5)] 
		[RED("onCollisionAction")] 
		public CEnum<gameprojectileOnCollisionAction> OnCollisionAction
		{
			get => GetProperty(ref _onCollisionAction);
			set => SetProperty(ref _onCollisionAction, value);
		}

		[Ordinal(6)] 
		[RED("useSweepCollision")] 
		public CBool UseSweepCollision
		{
			get => GetProperty(ref _useSweepCollision);
			set => SetProperty(ref _useSweepCollision, value);
		}

		[Ordinal(7)] 
		[RED("collisionsFilterClosest")] 
		public CBool CollisionsFilterClosest
		{
			get => GetProperty(ref _collisionsFilterClosest);
			set => SetProperty(ref _collisionsFilterClosest, value);
		}

		[Ordinal(8)] 
		[RED("sweepCollisionRadius")] 
		public CFloat SweepCollisionRadius
		{
			get => GetProperty(ref _sweepCollisionRadius);
			set => SetProperty(ref _sweepCollisionRadius, value);
		}

		[Ordinal(9)] 
		[RED("rotationOffset")] 
		public Quaternion RotationOffset
		{
			get => GetProperty(ref _rotationOffset);
			set => SetProperty(ref _rotationOffset, value);
		}

		[Ordinal(10)] 
		[RED("deriveOwnerVelocity")] 
		public CBool DeriveOwnerVelocity
		{
			get => GetProperty(ref _deriveOwnerVelocity);
			set => SetProperty(ref _deriveOwnerVelocity, value);
		}

		[Ordinal(11)] 
		[RED("derivedVelocityParams")] 
		public gameprojectileVelocityParams DerivedVelocityParams
		{
			get => GetProperty(ref _derivedVelocityParams);
			set => SetProperty(ref _derivedVelocityParams, value);
		}

		[Ordinal(12)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(13)] 
		[RED("previewEffect")] 
		public raRef<worldEffect> PreviewEffect
		{
			get => GetProperty(ref _previewEffect);
			set => SetProperty(ref _previewEffect, value);
		}

		[Ordinal(14)] 
		[RED("bouncePreviewEffect")] 
		public raRef<worldEffect> BouncePreviewEffect
		{
			get => GetProperty(ref _bouncePreviewEffect);
			set => SetProperty(ref _bouncePreviewEffect, value);
		}

		[Ordinal(15)] 
		[RED("explosionPreviewEffect")] 
		public raRef<worldEffect> ExplosionPreviewEffect
		{
			get => GetProperty(ref _explosionPreviewEffect);
			set => SetProperty(ref _explosionPreviewEffect, value);
		}

		[Ordinal(16)] 
		[RED("explosionPreviewTime")] 
		public CFloat ExplosionPreviewTime
		{
			get => GetProperty(ref _explosionPreviewTime);
			set => SetProperty(ref _explosionPreviewTime, value);
		}

		[Ordinal(17)] 
		[RED("gameEffectRef")] 
		public gameEffectRef GameEffectRef
		{
			get => GetProperty(ref _gameEffectRef);
			set => SetProperty(ref _gameEffectRef, value);
		}

		public gameprojectileComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

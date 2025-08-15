using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cameraShotEffect_Translation : vehicleTimedCinematicCameraShotEffect
	{
		[Ordinal(3)] 
		[RED("movementCurve")] 
		public CName MovementCurve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("targetTransform")] 
		public Transform TargetTransform
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		[Ordinal(5)] 
		[RED("affectedAxisPosition")] 
		public cameraShotEffect_TranslationAffectedAxis AffectedAxisPosition
		{
			get => GetPropertyValue<cameraShotEffect_TranslationAffectedAxis>();
			set => SetPropertyValue<cameraShotEffect_TranslationAffectedAxis>(value);
		}

		[Ordinal(6)] 
		[RED("ignoreRotation")] 
		public CBool IgnoreRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("startTransformShotSpace")] 
		public Transform StartTransformShotSpace
		{
			get => GetPropertyValue<Transform>();
			set => SetPropertyValue<Transform>(value);
		}

		public cameraShotEffect_Translation()
		{
			TargetTransform = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };
			AffectedAxisPosition = new cameraShotEffect_TranslationAffectedAxis { X = true, Y = true, Z = true };
			StartTransformShotSpace = new Transform { Position = new Vector4(), Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApplyAnimWrappersOnWeapon : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("refOwner")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(4)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetPropertyValue<CHandle<entAnimationControllerComponent>>();
			set => SetPropertyValue<CHandle<entAnimationControllerComponent>>(value);
		}

		public ApplyAnimWrappersOnWeapon()
		{
			OwnerPosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

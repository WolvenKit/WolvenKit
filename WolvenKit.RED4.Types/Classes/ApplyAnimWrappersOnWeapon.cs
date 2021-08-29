using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyAnimWrappersOnWeapon : AIbehaviortaskScript
	{
		private CName _wrapperName;
		private CWeakHandle<gamedataAIActionTarget_Record> _refOwner;
		private CWeakHandle<gameObject> _owner;
		private Vector4 _ownerPosition;
		private CHandle<entAnimationControllerComponent> _animationController;

		[Ordinal(0)] 
		[RED("wrapperName")] 
		public CName WrapperName
		{
			get => GetProperty(ref _wrapperName);
			set => SetProperty(ref _wrapperName, value);
		}

		[Ordinal(1)] 
		[RED("refOwner")] 
		public CWeakHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get => GetProperty(ref _refOwner);
			set => SetProperty(ref _refOwner, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public CWeakHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(3)] 
		[RED("ownerPosition")] 
		public Vector4 OwnerPosition
		{
			get => GetProperty(ref _ownerPosition);
			set => SetProperty(ref _ownerPosition, value);
		}

		[Ordinal(4)] 
		[RED("animationController")] 
		public CHandle<entAnimationControllerComponent> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}
	}
}

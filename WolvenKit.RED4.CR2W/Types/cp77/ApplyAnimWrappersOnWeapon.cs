using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyAnimWrappersOnWeapon : AIbehaviortaskScript
	{
		private CName _wrapperName;
		private wCHandle<gamedataAIActionTarget_Record> _refOwner;
		private wCHandle<gameObject> _owner;
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
		public wCHandle<gamedataAIActionTarget_Record> RefOwner
		{
			get => GetProperty(ref _refOwner);
			set => SetProperty(ref _refOwner, value);
		}

		[Ordinal(2)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
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

		public ApplyAnimWrappersOnWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

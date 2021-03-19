using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationControllerComponent : entIComponent
	{
		private rRef<animActionAnimDatabase> _actionAnimDatabaseRef;
		private animAnimDatabaseCollection _animDatabaseCollection;
		private CHandle<entAnimationControlBinding> _controlBinding;

		[Ordinal(3)] 
		[RED("actionAnimDatabaseRef")] 
		public rRef<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetProperty(ref _actionAnimDatabaseRef);
			set => SetProperty(ref _actionAnimDatabaseRef, value);
		}

		[Ordinal(4)] 
		[RED("animDatabaseCollection")] 
		public animAnimDatabaseCollection AnimDatabaseCollection
		{
			get => GetProperty(ref _animDatabaseCollection);
			set => SetProperty(ref _animDatabaseCollection, value);
		}

		[Ordinal(5)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetProperty(ref _controlBinding);
			set => SetProperty(ref _controlBinding, value);
		}

		public entAnimationControllerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

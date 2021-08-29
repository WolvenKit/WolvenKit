using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimationControllerComponent : entIComponent
	{
		private CResourceReference<animActionAnimDatabase> _actionAnimDatabaseRef;
		private animAnimDatabaseCollection _animDatabaseCollection;
		private CHandle<entAnimationControlBinding> _controlBinding;

		[Ordinal(3)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
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
	}
}

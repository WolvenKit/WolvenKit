using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RandomizationLockListItem : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("checker")] 
		public inkWidgetReference Checker
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("hitArea")] 
		public inkWidgetReference HitArea
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("lockName")] 
		public inkTextWidgetReference LockName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("navigationController")] 
		public CWeakHandle<inkDiscreteNavigationController> NavigationController
		{
			get => GetPropertyValue<CWeakHandle<inkDiscreteNavigationController>>();
			set => SetPropertyValue<CWeakHandle<inkDiscreteNavigationController>>(value);
		}

		[Ordinal(6)] 
		[RED("lockCategory")] 
		public CWeakHandle<gamedataCharacterRandomizationCategory_Record> LockCategory
		{
			get => GetPropertyValue<CWeakHandle<gamedataCharacterRandomizationCategory_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataCharacterRandomizationCategory_Record>>(value);
		}

		[Ordinal(7)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isInteractable")] 
		public CBool IsInteractable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		public RandomizationLockListItem()
		{
			Checker = new inkWidgetReference();
			LockIcon = new inkWidgetReference();
			HitArea = new inkWidgetReference();
			LockName = new inkTextWidgetReference();
			IsInteractable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

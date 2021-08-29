using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StatsViewController : inkWidgetLogicController
	{
		private inkTextWidgetReference _statLabelRef;
		private inkTextWidgetReference _statValueRef;
		private inkImageWidgetReference _icon;
		private gameStatViewData _stat;
		private CWeakHandle<inkButtonController> _buttonConctroller;

		[Ordinal(1)] 
		[RED("StatLabelRef")] 
		public inkTextWidgetReference StatLabelRef
		{
			get => GetProperty(ref _statLabelRef);
			set => SetProperty(ref _statLabelRef, value);
		}

		[Ordinal(2)] 
		[RED("StatValueRef")] 
		public inkTextWidgetReference StatValueRef
		{
			get => GetProperty(ref _statValueRef);
			set => SetProperty(ref _statValueRef, value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("stat")] 
		public gameStatViewData Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(5)] 
		[RED("buttonConctroller")] 
		public CWeakHandle<inkButtonController> ButtonConctroller
		{
			get => GetProperty(ref _buttonConctroller);
			set => SetProperty(ref _buttonConctroller, value);
		}
	}
}

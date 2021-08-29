using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SendSpiderbotToPerformActionEvent : redEvent
	{
		private CWeakHandle<gameObject> _executor;

		[Ordinal(0)] 
		[RED("executor")] 
		public CWeakHandle<gameObject> Executor
		{
			get => GetProperty(ref _executor);
			set => SetProperty(ref _executor, value);
		}
	}
}

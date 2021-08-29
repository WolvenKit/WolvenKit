using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVisionModuleEvent : redEvent
	{
		private CName _changedModule;
		private CWeakHandle<gameObject> _activator;
		private CBool _activated;

		[Ordinal(0)] 
		[RED("changedModule")] 
		public CName ChangedModule
		{
			get => GetProperty(ref _changedModule);
			set => SetProperty(ref _changedModule, value);
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public CWeakHandle<gameObject> Activator
		{
			get => GetProperty(ref _activator);
			set => SetProperty(ref _activator, value);
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get => GetProperty(ref _activated);
			set => SetProperty(ref _activated, value);
		}
	}
}

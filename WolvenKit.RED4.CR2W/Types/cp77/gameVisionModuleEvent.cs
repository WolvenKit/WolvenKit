using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleEvent : redEvent
	{
		private CName _changedModule;
		private wCHandle<gameObject> _activator;
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
		public wCHandle<gameObject> Activator
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

		public gameVisionModuleEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

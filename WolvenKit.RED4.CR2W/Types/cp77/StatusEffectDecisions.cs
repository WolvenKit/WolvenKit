using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectDecisions : LocomotionGroundDecisions
	{
		private wCHandle<gameObject> _executionOwner;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private CString _statusEffectEnumName;

		[Ordinal(3)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(4)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(5)] 
		[RED("statusEffectEnumName")] 
		public CString StatusEffectEnumName
		{
			get => GetProperty(ref _statusEffectEnumName);
			set => SetProperty(ref _statusEffectEnumName, value);
		}

		public StatusEffectDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

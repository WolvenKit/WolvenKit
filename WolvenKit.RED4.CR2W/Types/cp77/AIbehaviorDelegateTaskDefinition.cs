using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDelegateTaskDefinition : AIbehaviorTaskDefinition
	{
		private AIbehaviorDelegateTaskRef _onActivate;
		private AIbehaviorDelegateTaskRef _onUpdate;
		private AIbehaviorDelegateTaskRef _onDeactivate;

		[Ordinal(1)] 
		[RED("onActivate")] 
		public AIbehaviorDelegateTaskRef OnActivate
		{
			get => GetProperty(ref _onActivate);
			set => SetProperty(ref _onActivate, value);
		}

		[Ordinal(2)] 
		[RED("onUpdate")] 
		public AIbehaviorDelegateTaskRef OnUpdate
		{
			get => GetProperty(ref _onUpdate);
			set => SetProperty(ref _onUpdate, value);
		}

		[Ordinal(3)] 
		[RED("onDeactivate")] 
		public AIbehaviorDelegateTaskRef OnDeactivate
		{
			get => GetProperty(ref _onDeactivate);
			set => SetProperty(ref _onDeactivate, value);
		}

		public AIbehaviorDelegateTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIShootCommand : AICombatRelatedCommand
	{
		private NodeRef _targetOverrideNodeRef;
		private gameEntityReference _targetOverridePuppetRef;
		private CFloat _duration;
		private CBool _once;

		[Ordinal(5)] 
		[RED("targetOverrideNodeRef")] 
		public NodeRef TargetOverrideNodeRef
		{
			get => GetProperty(ref _targetOverrideNodeRef);
			set => SetProperty(ref _targetOverrideNodeRef, value);
		}

		[Ordinal(6)] 
		[RED("targetOverridePuppetRef")] 
		public gameEntityReference TargetOverridePuppetRef
		{
			get => GetProperty(ref _targetOverridePuppetRef);
			set => SetProperty(ref _targetOverridePuppetRef, value);
		}

		[Ordinal(7)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(8)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetProperty(ref _once);
			set => SetProperty(ref _once, value);
		}

		public AIShootCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

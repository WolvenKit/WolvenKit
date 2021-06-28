using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMeleeAttackCommandParams : questScriptedAICommandParams
	{
		private NodeRef _targetOverrideNodeRef;
		private gameEntityReference _targetOverridePuppetRef;
		private CFloat _duration;

		[Ordinal(0)] 
		[RED("targetOverrideNodeRef")] 
		public NodeRef TargetOverrideNodeRef
		{
			get => GetProperty(ref _targetOverrideNodeRef);
			set => SetProperty(ref _targetOverrideNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("targetOverridePuppetRef")] 
		public gameEntityReference TargetOverridePuppetRef
		{
			get => GetProperty(ref _targetOverridePuppetRef);
			set => SetProperty(ref _targetOverridePuppetRef, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		public AIMeleeAttackCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

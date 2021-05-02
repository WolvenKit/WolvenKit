using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_ShootAt : questCombatNodeParams
	{
		private NodeRef _targetOverrideNode;
		private gameEntityReference _targetOverridePuppet;
		private CFloat _duration;
		private CBool _once;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("targetOverrideNode")] 
		public NodeRef TargetOverrideNode
		{
			get => GetProperty(ref _targetOverrideNode);
			set => SetProperty(ref _targetOverrideNode, value);
		}

		[Ordinal(1)] 
		[RED("targetOverridePuppet")] 
		public gameEntityReference TargetOverridePuppet
		{
			get => GetProperty(ref _targetOverridePuppet);
			set => SetProperty(ref _targetOverridePuppet, value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(3)] 
		[RED("once")] 
		public CBool Once
		{
			get => GetProperty(ref _once);
			set => SetProperty(ref _once, value);
		}

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetProperty(ref _immediately);
			set => SetProperty(ref _immediately, value);
		}

		public questCombatNodeParams_ShootAt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

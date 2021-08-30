using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIForceShootCommandParams : questScriptedAICommandParams
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

		public AIForceShootCommandParams()
		{
			_duration = -1.000000F;
		}
	}
}

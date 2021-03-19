using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _isInstant;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetProperty(ref _mountData);
			set => SetProperty(ref _mountData, value);
		}

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get => GetProperty(ref _workspotData);
			set => SetProperty(ref _workspotData, value);
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CHandle<AIArgumentMapping> IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		[Ordinal(3)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get => GetProperty(ref _behaviorCallbackName);
			set => SetProperty(ref _behaviorCallbackName, value);
		}

		public AIbehaviorMountEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey : animAnimNode_Base
	{
		private animPoseLink _inputLink;
		private CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> _provider;

		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetProperty(ref _inputLink);
			set => SetProperty(ref _inputLink, value);
		}

		[Ordinal(12)] 
		[RED("provider")] 
		public CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> Provider
		{
			get => GetProperty(ref _provider);
			set => SetProperty(ref _provider, value);
		}

		public animAnimNode_SetDrivenKey(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

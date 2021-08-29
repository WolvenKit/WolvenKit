using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SetDrivenKey : animAnimNode_Base
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
	}
}

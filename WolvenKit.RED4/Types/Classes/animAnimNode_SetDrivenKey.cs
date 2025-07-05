using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_SetDrivenKey : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(12)] 
		[RED("provider")] 
		public CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider> Provider
		{
			get => GetPropertyValue<CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider>>();
			set => SetPropertyValue<CHandle<animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider>>(value);
		}

		public animAnimNode_SetDrivenKey()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

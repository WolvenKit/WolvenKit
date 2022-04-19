using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIUseCoverCommand : AICombatRelatedCommand
	{
		[Ordinal(5)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(6)] 
		[RED("oneTimeSelection")] 
		public CBool OneTimeSelection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("forcedEntryAnimation")] 
		public CName ForcedEntryAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get => GetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>();
			set => SetPropertyValue<CArray<CEnum<AICoverExposureMethod>>>(value);
		}

		[Ordinal(9)] 
		[RED("limitToTheseExposureMethods")] 
		public CHandle<CoverCommandParams> LimitToTheseExposureMethods
		{
			get => GetPropertyValue<CHandle<CoverCommandParams>>();
			set => SetPropertyValue<CHandle<CoverCommandParams>>(value);
		}

		public AIUseCoverCommand()
		{
			ExposureMethods = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

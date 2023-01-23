using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questParamKeepDistance : ISerializable
	{
		[Ordinal(0)] 
		[RED("companionTargetRef")] 
		public CHandle<questUniversalRef> CompanionTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questParamKeepDistance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

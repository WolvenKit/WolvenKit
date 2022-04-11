using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gametargetingSystemTargetFilterResult : IScriptable
	{
		[Ordinal(0)] 
		[RED("hitEntId")] 
		public entEntityID HitEntId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("hitComponent")] 
		public CWeakHandle<entIComponent> HitComponent
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		public gametargetingSystemTargetFilterResult()
		{
			HitEntId = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

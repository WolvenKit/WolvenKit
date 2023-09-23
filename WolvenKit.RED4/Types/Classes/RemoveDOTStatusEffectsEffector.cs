using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveDOTStatusEffectsEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RemoveDOTStatusEffectsEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

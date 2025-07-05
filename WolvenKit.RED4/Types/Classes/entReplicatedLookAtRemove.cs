using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedLookAtRemove : entReplicatedLookAtData
	{
		[Ordinal(1)] 
		[RED("ref")] 
		public animLookAtRef Ref
		{
			get => GetPropertyValue<animLookAtRef>();
			set => SetPropertyValue<animLookAtRef>(value);
		}

		[Ordinal(2)] 
		[RED("hasOutTransition")] 
		public CFloat HasOutTransition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("outTransitionSpeed")] 
		public CFloat OutTransitionSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public entReplicatedLookAtRemove()
		{
			Ref = new animLookAtRef { Id = -1 };
			OutTransitionSpeed = 60.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

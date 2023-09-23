using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealInteractionWheel : redEvent
	{
		[Ordinal(0)] 
		[RED("lookAtObject")] 
		public CWeakHandle<gameObject> LookAtObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(1)] 
		[RED("commands")] 
		public CArray<CHandle<QuickhackData>> Commands
		{
			get => GetPropertyValue<CArray<CHandle<QuickhackData>>>();
			set => SetPropertyValue<CArray<CHandle<QuickhackData>>>(value);
		}

		[Ordinal(2)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RevealInteractionWheel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

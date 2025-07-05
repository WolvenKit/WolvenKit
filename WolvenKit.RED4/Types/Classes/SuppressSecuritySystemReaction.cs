using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SuppressSecuritySystemReaction : redEvent
	{
		[Ordinal(0)] 
		[RED("enableProtection")] 
		public CBool EnableProtection
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("protectedEntityID")] 
		public entEntityID ProtectedEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("hasEntityWithdrawn")] 
		public CBool HasEntityWithdrawn
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SuppressSecuritySystemReaction()
		{
			ProtectedEntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

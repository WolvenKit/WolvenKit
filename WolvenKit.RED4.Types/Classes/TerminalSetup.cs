using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TerminalSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("minClearance")] 
		public CInt32 MinClearance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("maxClearance")] 
		public CInt32 MaxClearance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ignoreSlaveAuthorizationModule")] 
		public CBool IgnoreSlaveAuthorizationModule
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("allowRemoteAuthorization")] 
		public CBool AllowRemoteAuthorization
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("shouldForceVirtualSystem")] 
		public CBool ShouldForceVirtualSystem
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TerminalSetup()
		{
			MinClearance = 1;
			MaxClearance = 10;
			ShouldForceVirtualSystem = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

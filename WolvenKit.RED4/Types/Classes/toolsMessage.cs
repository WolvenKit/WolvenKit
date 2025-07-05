using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class toolsMessage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("severity")] 
		public CEnum<toolsMessageSeverity> Severity
		{
			get => GetPropertyValue<CEnum<toolsMessageSeverity>>();
			set => SetPropertyValue<CEnum<toolsMessageSeverity>>(value);
		}

		[Ordinal(1)] 
		[RED("created")] 
		public CInt64 Created
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(2)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get => GetPropertyValue<CHandle<toolsIMessageLocation>>();
			set => SetPropertyValue<CHandle<toolsIMessageLocation>>(value);
		}

		[Ordinal(3)] 
		[RED("tokens")] 
		public CArray<CHandle<toolsIMessageToken>> Tokens
		{
			get => GetPropertyValue<CArray<CHandle<toolsIMessageToken>>>();
			set => SetPropertyValue<CArray<CHandle<toolsIMessageToken>>>(value);
		}

		[Ordinal(4)] 
		[RED("verbosity")] 
		public CEnum<toolsMessageVerbosity> Verbosity
		{
			get => GetPropertyValue<CEnum<toolsMessageVerbosity>>();
			set => SetPropertyValue<CEnum<toolsMessageVerbosity>>(value);
		}

		public toolsMessage()
		{
			Tokens = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

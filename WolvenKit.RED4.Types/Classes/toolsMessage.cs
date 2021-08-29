using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class toolsMessage : RedBaseClass
	{
		private CEnum<toolsMessageSeverity> _severity;
		private CInt64 _created;
		private CHandle<toolsIMessageLocation> _location;
		private CArray<CHandle<toolsIMessageToken>> _tokens;
		private CEnum<toolsMessageVerbosity> _verbosity;

		[Ordinal(0)] 
		[RED("severity")] 
		public CEnum<toolsMessageSeverity> Severity
		{
			get => GetProperty(ref _severity);
			set => SetProperty(ref _severity, value);
		}

		[Ordinal(1)] 
		[RED("created")] 
		public CInt64 Created
		{
			get => GetProperty(ref _created);
			set => SetProperty(ref _created, value);
		}

		[Ordinal(2)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get => GetProperty(ref _location);
			set => SetProperty(ref _location, value);
		}

		[Ordinal(3)] 
		[RED("tokens")] 
		public CArray<CHandle<toolsIMessageToken>> Tokens
		{
			get => GetProperty(ref _tokens);
			set => SetProperty(ref _tokens, value);
		}

		[Ordinal(4)] 
		[RED("verbosity")] 
		public CEnum<toolsMessageVerbosity> Verbosity
		{
			get => GetProperty(ref _verbosity);
			set => SetProperty(ref _verbosity, value);
		}
	}
}

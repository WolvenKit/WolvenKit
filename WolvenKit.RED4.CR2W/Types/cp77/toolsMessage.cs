using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsMessage : CVariable
	{
		private CEnum<toolsMessageSeverity> _severity;
		private CInt64 _created;
		private CHandle<toolsIMessageLocation> _location;
		private CArray<CHandle<toolsIMessageToken>> _tokens;

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

		public toolsMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

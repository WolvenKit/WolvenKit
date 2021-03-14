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
			get
			{
				if (_severity == null)
				{
					_severity = (CEnum<toolsMessageSeverity>) CR2WTypeManager.Create("toolsMessageSeverity", "severity", cr2w, this);
				}
				return _severity;
			}
			set
			{
				if (_severity == value)
				{
					return;
				}
				_severity = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("created")] 
		public CInt64 Created
		{
			get
			{
				if (_created == null)
				{
					_created = (CInt64) CR2WTypeManager.Create("Int64", "created", cr2w, this);
				}
				return _created;
			}
			set
			{
				if (_created == value)
				{
					return;
				}
				_created = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("location")] 
		public CHandle<toolsIMessageLocation> Location
		{
			get
			{
				if (_location == null)
				{
					_location = (CHandle<toolsIMessageLocation>) CR2WTypeManager.Create("handle:toolsIMessageLocation", "location", cr2w, this);
				}
				return _location;
			}
			set
			{
				if (_location == value)
				{
					return;
				}
				_location = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tokens")] 
		public CArray<CHandle<toolsIMessageToken>> Tokens
		{
			get
			{
				if (_tokens == null)
				{
					_tokens = (CArray<CHandle<toolsIMessageToken>>) CR2WTypeManager.Create("array:handle:toolsIMessageToken", "tokens", cr2w, this);
				}
				return _tokens;
			}
			set
			{
				if (_tokens == value)
				{
					return;
				}
				_tokens = value;
				PropertySet(this);
			}
		}

		public toolsMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

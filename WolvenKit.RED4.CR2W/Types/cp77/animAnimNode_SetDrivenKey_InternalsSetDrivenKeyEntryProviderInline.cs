using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline : animAnimNode_SetDrivenKey_InternalsISetDrivenKeyEntryProvider
	{
		private CArray<animAnimNode_SetDrivenKey_InternalsEntry> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAnimNode_SetDrivenKey_InternalsEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<animAnimNode_SetDrivenKey_InternalsEntry>) CR2WTypeManager.Create("array:animAnimNode_SetDrivenKey_InternalsEntry", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SetDrivenKey_InternalsSetDrivenKeyEntryProviderInline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

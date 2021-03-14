using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalDescriptorResource : gameJournalBaseResource
	{
		private CArray<CString> _entriesActivatedAtStart;

		[Ordinal(1)] 
		[RED("entriesActivatedAtStart")] 
		public CArray<CString> EntriesActivatedAtStart
		{
			get
			{
				if (_entriesActivatedAtStart == null)
				{
					_entriesActivatedAtStart = (CArray<CString>) CR2WTypeManager.Create("array:String", "entriesActivatedAtStart", cr2w, this);
				}
				return _entriesActivatedAtStart;
			}
			set
			{
				if (_entriesActivatedAtStart == value)
				{
					return;
				}
				_entriesActivatedAtStart = value;
				PropertySet(this);
			}
		}

		public gameJournalDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

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
			get => GetProperty(ref _entriesActivatedAtStart);
			set => SetProperty(ref _entriesActivatedAtStart, value);
		}

		public gameJournalDescriptorResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

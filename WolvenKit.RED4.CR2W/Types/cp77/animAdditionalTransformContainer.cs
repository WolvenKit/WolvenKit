using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAdditionalTransformContainer : CVariable
	{
		private CArray<CHandle<animAdditionalTransformEntry>> _entries;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CHandle<animAdditionalTransformEntry>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		public animAdditionalTransformContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

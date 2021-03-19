using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAdditionalFloatTrackContainer : CVariable
	{
		private CArray<animAdditionalFloatTrackEntry> _entries;
		private CBool _overwriteExistingValues;

		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animAdditionalFloatTrackEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(1)] 
		[RED("overwriteExistingValues")] 
		public CBool OverwriteExistingValues
		{
			get => GetProperty(ref _overwriteExistingValues);
			set => SetProperty(ref _overwriteExistingValues, value);
		}

		public animAdditionalFloatTrackContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityArea : ISerializable
	{
		private CArray<communityCommunityEntrySpotsData> _entriesData;

		[Ordinal(0)] 
		[RED("entriesData")] 
		public CArray<communityCommunityEntrySpotsData> EntriesData
		{
			get => GetProperty(ref _entriesData);
			set => SetProperty(ref _entriesData, value);
		}

		public communityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

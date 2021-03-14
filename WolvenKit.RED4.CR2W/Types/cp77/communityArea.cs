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
			get
			{
				if (_entriesData == null)
				{
					_entriesData = (CArray<communityCommunityEntrySpotsData>) CR2WTypeManager.Create("array:communityCommunityEntrySpotsData", "entriesData", cr2w, this);
				}
				return _entriesData;
			}
			set
			{
				if (_entriesData == value)
				{
					return;
				}
				_entriesData = value;
				PropertySet(this);
			}
		}

		public communityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

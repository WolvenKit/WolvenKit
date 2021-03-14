using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SetBoneTransform : animAnimNode_OnePoseInput
	{
		private CArray<animSetBoneTransformEntry> _entries;

		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<animSetBoneTransformEntry> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<animSetBoneTransformEntry>) CR2WTypeManager.Create("array:animSetBoneTransformEntry", "entries", cr2w, this);
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

		public animAnimNode_SetBoneTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

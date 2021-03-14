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
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<animAdditionalFloatTrackEntry>) CR2WTypeManager.Create("array:animAdditionalFloatTrackEntry", "entries", cr2w, this);
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

		[Ordinal(1)] 
		[RED("overwriteExistingValues")] 
		public CBool OverwriteExistingValues
		{
			get
			{
				if (_overwriteExistingValues == null)
				{
					_overwriteExistingValues = (CBool) CR2WTypeManager.Create("Bool", "overwriteExistingValues", cr2w, this);
				}
				return _overwriteExistingValues;
			}
			set
			{
				if (_overwriteExistingValues == value)
				{
					return;
				}
				_overwriteExistingValues = value;
				PropertySet(this);
			}
		}

		public animAdditionalFloatTrackContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

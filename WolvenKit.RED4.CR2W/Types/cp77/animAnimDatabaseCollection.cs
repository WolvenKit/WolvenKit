using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDatabaseCollection : CVariable
	{
		private CArray<animAnimDatabaseCollectionEntry> _animDatabases;

		[Ordinal(0)] 
		[RED("animDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AnimDatabases
		{
			get
			{
				if (_animDatabases == null)
				{
					_animDatabases = (CArray<animAnimDatabaseCollectionEntry>) CR2WTypeManager.Create("array:animAnimDatabaseCollectionEntry", "animDatabases", cr2w, this);
				}
				return _animDatabases;
			}
			set
			{
				if (_animDatabases == value)
				{
					return;
				}
				_animDatabases = value;
				PropertySet(this);
			}
		}

		public animAnimDatabaseCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

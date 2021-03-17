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
			get => GetProperty(ref _animDatabases);
			set => SetProperty(ref _animDatabases, value);
		}

		public animAnimDatabaseCollection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

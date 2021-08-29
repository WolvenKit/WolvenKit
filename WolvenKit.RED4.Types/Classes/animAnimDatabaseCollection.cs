using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDatabaseCollection : RedBaseClass
	{
		private CArray<animAnimDatabaseCollectionEntry> _animDatabases;

		[Ordinal(0)] 
		[RED("animDatabases")] 
		public CArray<animAnimDatabaseCollectionEntry> AnimDatabases
		{
			get => GetProperty(ref _animDatabases);
			set => SetProperty(ref _animDatabases, value);
		}
	}
}

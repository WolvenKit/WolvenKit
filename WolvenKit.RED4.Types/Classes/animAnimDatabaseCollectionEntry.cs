using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimDatabaseCollectionEntry : RedBaseClass
	{
		private CName _name;
		private CResourceReference<C2dArray> _animDatabase;
		private CResourceReference<animGenericAnimDatabase> _overrideAnimDatabase;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("animDatabase")] 
		public CResourceReference<C2dArray> AnimDatabase
		{
			get => GetProperty(ref _animDatabase);
			set => SetProperty(ref _animDatabase, value);
		}

		[Ordinal(2)] 
		[RED("overrideAnimDatabase")] 
		public CResourceReference<animGenericAnimDatabase> OverrideAnimDatabase
		{
			get => GetProperty(ref _overrideAnimDatabase);
			set => SetProperty(ref _overrideAnimDatabase, value);
		}
	}
}

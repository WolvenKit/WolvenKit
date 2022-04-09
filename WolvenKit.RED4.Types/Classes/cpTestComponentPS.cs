using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class cpTestComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("something")] 
		public CInt32 Something
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("somethingNotInstanceEdiable")] 
		public CBool SomethingNotInstanceEdiable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("nameEditable")] 
		public CName NameEditable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("nameInstanceEditable")] 
		public CName NameInstanceEditable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("namePersistent")] 
		public CName NamePersistent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("namePersistentEdiable")] 
		public CName NamePersistentEdiable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("namePersistentInstanceEditable")] 
		public CName NamePersistentInstanceEditable
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public cpTestComponentPS()
		{
			NameEditable = "E";
			NameInstanceEditable = "IE";
			NamePersistent = "P";
			NamePersistentEdiable = "PE";
			NamePersistentInstanceEditable = "PIE";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

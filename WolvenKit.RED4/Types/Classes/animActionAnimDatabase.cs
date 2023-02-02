using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animActionAnimDatabase : CResource
	{
		[Ordinal(1)] 
		[RED("rows")] 
		public CArray<animActionAnimDatabase_DatabaseRow> Rows
		{
			get => GetPropertyValue<CArray<animActionAnimDatabase_DatabaseRow>>();
			set => SetPropertyValue<CArray<animActionAnimDatabase_DatabaseRow>>(value);
		}

		public animActionAnimDatabase()
		{
			Rows = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

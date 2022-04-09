using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animGenericAnimDatabase : CResource
	{
		[Ordinal(1)] 
		[RED("rows")] 
		public CArray<animGenericAnimDatabase_DatabaseRow> Rows
		{
			get => GetPropertyValue<CArray<animGenericAnimDatabase_DatabaseRow>>();
			set => SetPropertyValue<CArray<animGenericAnimDatabase_DatabaseRow>>(value);
		}

		public animGenericAnimDatabase()
		{
			Rows = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

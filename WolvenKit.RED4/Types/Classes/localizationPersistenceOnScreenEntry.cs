using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class localizationPersistenceOnScreenEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("primaryKey")] 
		public CUInt64 PrimaryKey
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("secondaryKey")] 
		public CString SecondaryKey
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("femaleVariant")] 
		public CString FemaleVariant
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("maleVariant")] 
		public CString MaleVariant
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public localizationPersistenceOnScreenEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

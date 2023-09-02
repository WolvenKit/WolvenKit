using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PSOwnerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public gamePersistentID Id
		{
			get => GetPropertyValue<gamePersistentID>();
			set => SetPropertyValue<gamePersistentID>(value);
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public PSOwnerData()
		{
			Id = new gamePersistentID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

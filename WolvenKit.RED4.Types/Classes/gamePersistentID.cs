using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePersistentID : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entityHash")] 
		public CUInt64 EntityHash
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		[Ordinal(1)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gamePersistentID()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

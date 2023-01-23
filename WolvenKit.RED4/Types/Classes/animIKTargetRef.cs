using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animIKTargetRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("part")] 
		public CName Part
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animIKTargetRef()
		{
			Id = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

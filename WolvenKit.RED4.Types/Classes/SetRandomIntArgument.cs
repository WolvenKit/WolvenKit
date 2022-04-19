using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetRandomIntArgument : AIRandomTasks
	{
		[Ordinal(0)] 
		[RED("MaxValue")] 
		public CInt32 MaxValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("MinValue")] 
		public CInt32 MinValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("ArgumentName")] 
		public CName ArgumentName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SetRandomIntArgument()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

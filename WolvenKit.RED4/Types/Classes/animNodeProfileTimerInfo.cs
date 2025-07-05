using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animNodeProfileTimerInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<animNodeProfileTimerMode> Mode
		{
			get => GetPropertyValue<CEnum<animNodeProfileTimerMode>>();
			set => SetPropertyValue<CEnum<animNodeProfileTimerMode>>(value);
		}

		public animNodeProfileTimerInfo()
		{
			Mode = Enums.animNodeProfileTimerMode.End;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

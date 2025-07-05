using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SPerformedActions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ID")] 
		public CName ID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("ActionContext")] 
		public CArray<CEnum<EActionContext>> ActionContext
		{
			get => GetPropertyValue<CArray<CEnum<EActionContext>>>();
			set => SetPropertyValue<CArray<CEnum<EActionContext>>>(value);
		}

		public SPerformedActions()
		{
			ActionContext = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

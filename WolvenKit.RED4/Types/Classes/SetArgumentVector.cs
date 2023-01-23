using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetArgumentVector : SetArguments
	{
		[Ordinal(1)] 
		[RED("newValue")] 
		public CHandle<AIArgumentMapping> NewValue
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		public SetArgumentVector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

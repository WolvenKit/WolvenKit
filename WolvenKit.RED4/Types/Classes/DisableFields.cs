using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DisableFields : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("actionMask")] 
		public SBraindanceInputMask ActionMask
		{
			get => GetPropertyValue<SBraindanceInputMask>();
			set => SetPropertyValue<SBraindanceInputMask>(value);
		}

		public DisableFields()
		{
			ActionMask = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EnableFields : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("actionMask")] 
		public SBraindanceInputMask ActionMask
		{
			get => GetPropertyValue<SBraindanceInputMask>();
			set => SetPropertyValue<SBraindanceInputMask>(value);
		}

		public EnableFields()
		{
			ActionMask = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

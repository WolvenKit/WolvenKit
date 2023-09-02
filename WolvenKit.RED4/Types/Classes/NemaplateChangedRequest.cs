using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NemaplateChangedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("playerTarget")] 
		public entEntityID PlayerTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public NemaplateChangedRequest()
		{
			PlayerTarget = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

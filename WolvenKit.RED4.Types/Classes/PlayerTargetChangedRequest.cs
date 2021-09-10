using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerTargetChangedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("playerTarget")] 
		public entEntityID PlayerTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public PlayerTargetChangedRequest()
		{
			PlayerTarget = new();
		}
	}
}

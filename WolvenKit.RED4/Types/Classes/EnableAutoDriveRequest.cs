using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EnableAutoDriveRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isDelamain")] 
		public CBool IsDelamain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EnableAutoDriveRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

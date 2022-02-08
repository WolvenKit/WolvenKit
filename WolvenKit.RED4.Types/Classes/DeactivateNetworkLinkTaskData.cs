using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeactivateNetworkLinkTaskData : gameScriptTaskData
	{
		[Ordinal(0)] 
		[RED("linkIndex")] 
		public CInt32 LinkIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameDeviceBase : gameObject
	{
		[Ordinal(35)] 
		[RED("isLogicReady")] 
		public CBool IsLogicReady
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

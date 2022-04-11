using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasNetworkPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

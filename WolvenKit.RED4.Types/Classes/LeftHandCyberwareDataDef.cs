using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("ProjectileCaught")] 
		public gamebbScriptID_Bool ProjectileCaught
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public LeftHandCyberwareDataDef()
		{
			ProjectileCaught = new();
		}
	}
}

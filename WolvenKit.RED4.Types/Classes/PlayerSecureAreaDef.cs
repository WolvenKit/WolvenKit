using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlayerSecureAreaDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _inside;

		[Ordinal(0)] 
		[RED("inside")] 
		public gamebbScriptID_Bool Inside
		{
			get => GetProperty(ref _inside);
			set => SetProperty(ref _inside, value);
		}
	}
}

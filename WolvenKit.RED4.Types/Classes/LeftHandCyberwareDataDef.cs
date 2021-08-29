using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LeftHandCyberwareDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _projectileCaught;

		[Ordinal(0)] 
		[RED("ProjectileCaught")] 
		public gamebbScriptID_Bool ProjectileCaught
		{
			get => GetProperty(ref _projectileCaught);
			set => SetProperty(ref _projectileCaught, value);
		}
	}
}

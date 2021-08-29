using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MinesDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Vector4 _currentNormal;

		[Ordinal(0)] 
		[RED("CurrentNormal")] 
		public gamebbScriptID_Vector4 CurrentNormal
		{
			get => GetProperty(ref _currentNormal);
			set => SetProperty(ref _currentNormal, value);
		}
	}
}

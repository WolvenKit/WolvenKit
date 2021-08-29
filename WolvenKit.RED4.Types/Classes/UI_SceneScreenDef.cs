using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UI_SceneScreenDef : gamebbScriptDefinition
	{
		private gamebbScriptID_CName _animName;

		[Ordinal(0)] 
		[RED("AnimName")] 
		public gamebbScriptID_CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}
	}
}

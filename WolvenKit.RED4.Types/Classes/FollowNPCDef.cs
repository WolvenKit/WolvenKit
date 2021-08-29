using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FollowNPCDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Vector4 _position;

		[Ordinal(0)] 
		[RED("Position")] 
		public gamebbScriptID_Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}
	}
}

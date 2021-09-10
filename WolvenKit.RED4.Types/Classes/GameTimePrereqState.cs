using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameTimePrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CUInt32 Listener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}

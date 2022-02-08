using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionSceneInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("previousLocomotionState")] 
		public CInt32 PreviousLocomotionState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LocomotionSceneInitData : IScriptable
	{
		[Ordinal(0)] 
		[RED("previousLocomotionState")] 
		public CInt32 PreviousLocomotionState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LocomotionSceneInitData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}

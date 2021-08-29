using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleVisibleObjectComponent : StatusEffectTasks
	{
		private CBool _componentTargetState;
		private CName _visibleObjectDescription;

		[Ordinal(0)] 
		[RED("componentTargetState")] 
		public CBool ComponentTargetState
		{
			get => GetProperty(ref _componentTargetState);
			set => SetProperty(ref _componentTargetState, value);
		}

		[Ordinal(1)] 
		[RED("visibleObjectDescription")] 
		public CName VisibleObjectDescription
		{
			get => GetProperty(ref _visibleObjectDescription);
			set => SetProperty(ref _visibleObjectDescription, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInputController_ConditionType : questISystemConditionType
	{
		private CEnum<questInputDevice> _inputController;

		[Ordinal(0)] 
		[RED("inputController")] 
		public CEnum<questInputDevice> InputController
		{
			get => GetProperty(ref _inputController);
			set => SetProperty(ref _inputController, value);
		}
	}
}

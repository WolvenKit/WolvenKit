using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questInputController_ConditionType : questISystemConditionType
	{
		[Ordinal(0)] 
		[RED("inputController")] 
		public CEnum<questInputDevice> InputController
		{
			get => GetPropertyValue<CEnum<questInputDevice>>();
			set => SetPropertyValue<CEnum<questInputDevice>>(value);
		}
	}
}

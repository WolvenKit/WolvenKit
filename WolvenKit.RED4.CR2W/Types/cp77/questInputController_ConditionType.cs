using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputController_ConditionType : questISystemConditionType
	{
		private CEnum<questInputDevice> _inputController;

		[Ordinal(0)] 
		[RED("inputController")] 
		public CEnum<questInputDevice> InputController
		{
			get => GetProperty(ref _inputController);
			set => SetProperty(ref _inputController, value);
		}

		public questInputController_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

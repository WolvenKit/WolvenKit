using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInputAction_ConditionType : questISystemConditionType
	{
		private CBool _anyInputAction;
		private CName _inputAction;
		private CBool _checkIfButtonAlreadyPressed;
		private CBool _axisAction;
		private CFloat _valueLessThan;
		private CFloat _valueMoreThan;

		[Ordinal(0)] 
		[RED("anyInputAction")] 
		public CBool AnyInputAction
		{
			get => GetProperty(ref _anyInputAction);
			set => SetProperty(ref _anyInputAction, value);
		}

		[Ordinal(1)] 
		[RED("inputAction")] 
		public CName InputAction
		{
			get => GetProperty(ref _inputAction);
			set => SetProperty(ref _inputAction, value);
		}

		[Ordinal(2)] 
		[RED("checkIfButtonAlreadyPressed")] 
		public CBool CheckIfButtonAlreadyPressed
		{
			get => GetProperty(ref _checkIfButtonAlreadyPressed);
			set => SetProperty(ref _checkIfButtonAlreadyPressed, value);
		}

		[Ordinal(3)] 
		[RED("axisAction")] 
		public CBool AxisAction
		{
			get => GetProperty(ref _axisAction);
			set => SetProperty(ref _axisAction, value);
		}

		[Ordinal(4)] 
		[RED("valueLessThan")] 
		public CFloat ValueLessThan
		{
			get => GetProperty(ref _valueLessThan);
			set => SetProperty(ref _valueLessThan, value);
		}

		[Ordinal(5)] 
		[RED("valueMoreThan")] 
		public CFloat ValueMoreThan
		{
			get => GetProperty(ref _valueMoreThan);
			set => SetProperty(ref _valueMoreThan, value);
		}

		public questInputAction_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

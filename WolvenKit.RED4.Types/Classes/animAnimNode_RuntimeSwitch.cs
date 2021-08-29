using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		private CHandle<animIRuntimeCondition> _condition;
		private animPoseLink _true;
		private animPoseLink _false;

		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIRuntimeCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(12)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetProperty(ref _true);
			set => SetProperty(ref _true, value);
		}

		[Ordinal(13)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetProperty(ref _false);
			set => SetProperty(ref _false, value);
		}
	}
}

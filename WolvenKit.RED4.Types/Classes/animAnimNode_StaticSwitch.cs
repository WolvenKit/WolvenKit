using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_StaticSwitch : animAnimNode_MotionTableSwitch
	{
		private CHandle<animIStaticCondition> _condition;
		private CHandle<animIMotionTableProvider> _motionProvider;
		private animPoseLink _true;
		private animPoseLink _false;

		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(12)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetProperty(ref _motionProvider);
			set => SetProperty(ref _motionProvider, value);
		}

		[Ordinal(13)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetProperty(ref _true);
			set => SetProperty(ref _true, value);
		}

		[Ordinal(14)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetProperty(ref _false);
			set => SetProperty(ref _false, value);
		}
	}
}

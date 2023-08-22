using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StaticSwitch : animAnimNode_MotionTableSwitch
	{
		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIStaticCondition>>();
			set => SetPropertyValue<CHandle<animIStaticCondition>>(value);
		}

		[Ordinal(12)] 
		[RED("motionProvider")] 
		public CHandle<animIMotionTableProvider> MotionProvider
		{
			get => GetPropertyValue<CHandle<animIMotionTableProvider>>();
			set => SetPropertyValue<CHandle<animIMotionTableProvider>>(value);
		}

		[Ordinal(13)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(14)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_StaticSwitch()
		{
			Id = uint.MaxValue;
			True = new animPoseLink();
			False = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

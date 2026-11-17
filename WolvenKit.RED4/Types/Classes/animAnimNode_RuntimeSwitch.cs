using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		[Ordinal(1)] 
		[RED("condition")] 
		public CHandle<animIRuntimeCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIRuntimeCondition>>();
			set => SetPropertyValue<CHandle<animIRuntimeCondition>>(value);
		}

		[Ordinal(2)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(3)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_RuntimeSwitch()
		{
			Id = uint.MaxValue;
			True = new animPoseLink();
			False = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

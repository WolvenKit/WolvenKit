using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_RuntimeSwitch : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("condition")] 
		public CHandle<animIRuntimeCondition> Condition
		{
			get => GetPropertyValue<CHandle<animIRuntimeCondition>>();
			set => SetPropertyValue<CHandle<animIRuntimeCondition>>(value);
		}

		[Ordinal(12)] 
		[RED("True")] 
		public animPoseLink True
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		[Ordinal(13)] 
		[RED("False")] 
		public animPoseLink False
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_RuntimeSwitch()
		{
			Id = 4294967295;
			True = new();
			False = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

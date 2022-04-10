using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SStimOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stimType")] 
		public CEnum<DeviceStimType> StimType
		{
			get => GetPropertyValue<CEnum<DeviceStimType>>();
			set => SetPropertyValue<CEnum<DeviceStimType>>(value);
		}

		[Ordinal(1)] 
		[RED("lifeTime")] 
		public CFloat LifeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EEffectOperationType> OperationType
		{
			get => GetPropertyValue<CEnum<EEffectOperationType>>();
			set => SetPropertyValue<CEnum<EEffectOperationType>>(value);
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public SStimOperationData()
		{
			LifeTime = 3.000000F;
			Radius = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

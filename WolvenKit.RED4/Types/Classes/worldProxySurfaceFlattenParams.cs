using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldProxySurfaceFlattenParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("flatten")] 
		public CBool Flatten
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("groupingStepAngle")] 
		public CEnum<worldProxyNormalAngleStepSize> GroupingStepAngle
		{
			get => GetPropertyValue<CEnum<worldProxyNormalAngleStepSize>>();
			set => SetPropertyValue<CEnum<worldProxyNormalAngleStepSize>>(value);
		}

		[Ordinal(2)] 
		[RED("syncNormalSource")] 
		public CEnum<worldProxySyncNormalSource> SyncNormalSource
		{
			get => GetPropertyValue<CEnum<worldProxySyncNormalSource>>();
			set => SetPropertyValue<CEnum<worldProxySyncNormalSource>>(value);
		}

		[Ordinal(3)] 
		[RED("coreAxisRotationOffset")] 
		public CFloat CoreAxisRotationOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("postFlattenReduce")] 
		public CBool PostFlattenReduce
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldProxySurfaceFlattenParams()
		{
			GroupingStepAngle = Enums.worldProxyNormalAngleStepSize.STEP_45;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

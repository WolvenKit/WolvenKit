using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxySurfaceFlattenParams : RedBaseClass
	{
		private CBool _flatten;
		private CEnum<worldProxyNormalAngleStepSize> _groupingStepAngle;
		private CEnum<worldProxySyncNormalSource> _syncNormalSource;
		private CFloat _coreAxisRotationOffset;
		private CBool _postFlattenReduce;

		[Ordinal(0)] 
		[RED("flatten")] 
		public CBool Flatten
		{
			get => GetProperty(ref _flatten);
			set => SetProperty(ref _flatten, value);
		}

		[Ordinal(1)] 
		[RED("groupingStepAngle")] 
		public CEnum<worldProxyNormalAngleStepSize> GroupingStepAngle
		{
			get => GetProperty(ref _groupingStepAngle);
			set => SetProperty(ref _groupingStepAngle, value);
		}

		[Ordinal(2)] 
		[RED("syncNormalSource")] 
		public CEnum<worldProxySyncNormalSource> SyncNormalSource
		{
			get => GetProperty(ref _syncNormalSource);
			set => SetProperty(ref _syncNormalSource, value);
		}

		[Ordinal(3)] 
		[RED("coreAxisRotationOffset")] 
		public CFloat CoreAxisRotationOffset
		{
			get => GetProperty(ref _coreAxisRotationOffset);
			set => SetProperty(ref _coreAxisRotationOffset, value);
		}

		[Ordinal(4)] 
		[RED("postFlattenReduce")] 
		public CBool PostFlattenReduce
		{
			get => GetProperty(ref _postFlattenReduce);
			set => SetProperty(ref _postFlattenReduce, value);
		}
	}
}

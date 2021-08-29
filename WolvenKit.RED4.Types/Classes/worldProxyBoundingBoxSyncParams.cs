using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldProxyBoundingBoxSyncParams : RedBaseClass
	{
		private CEnum<worldProxyBBoxSyncOptions> _positiveAxis;
		private CEnum<worldProxyBBoxSyncOptions> _negativeAxis;
		private CFloat _pullRange;
		private CBool _makeStackable;
		private Vector3 _stackOffset;

		[Ordinal(0)] 
		[RED("positiveAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> PositiveAxis
		{
			get => GetProperty(ref _positiveAxis);
			set => SetProperty(ref _positiveAxis, value);
		}

		[Ordinal(1)] 
		[RED("negativeAxis")] 
		public CEnum<worldProxyBBoxSyncOptions> NegativeAxis
		{
			get => GetProperty(ref _negativeAxis);
			set => SetProperty(ref _negativeAxis, value);
		}

		[Ordinal(2)] 
		[RED("pullRange")] 
		public CFloat PullRange
		{
			get => GetProperty(ref _pullRange);
			set => SetProperty(ref _pullRange, value);
		}

		[Ordinal(3)] 
		[RED("makeStackable")] 
		public CBool MakeStackable
		{
			get => GetProperty(ref _makeStackable);
			set => SetProperty(ref _makeStackable, value);
		}

		[Ordinal(4)] 
		[RED("stackOffset")] 
		public Vector3 StackOffset
		{
			get => GetProperty(ref _stackOffset);
			set => SetProperty(ref _stackOffset, value);
		}
	}
}

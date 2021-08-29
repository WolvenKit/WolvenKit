using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyStatusEffectEffector : gameEffector
	{
		private entEntityID _targetEntityID;
		private CString _applicationTarget;
		private TweakDBID _record;
		private CBool _removeWithEffector;
		private CBool _inverted;
		private CFloat _count;
		private CString _instigator;

		[Ordinal(0)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetProperty(ref _targetEntityID);
			set => SetProperty(ref _targetEntityID, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CString ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(3)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get => GetProperty(ref _removeWithEffector);
			set => SetProperty(ref _removeWithEffector, value);
		}

		[Ordinal(4)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(5)] 
		[RED("count")] 
		public CFloat Count
		{
			get => GetProperty(ref _count);
			set => SetProperty(ref _count, value);
		}

		[Ordinal(6)] 
		[RED("instigator")] 
		public CString Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}
	}
}

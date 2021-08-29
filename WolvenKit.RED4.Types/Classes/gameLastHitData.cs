using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameLastHitData : RedBaseClass
	{
		private entEntityID _targetEntityId;
		private CUInt32 _hitType;
		private CArray<CName> _hitShapes;

		[Ordinal(0)] 
		[RED("targetEntityId")] 
		public entEntityID TargetEntityId
		{
			get => GetProperty(ref _targetEntityId);
			set => SetProperty(ref _targetEntityId, value);
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CUInt32 HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		[Ordinal(2)] 
		[RED("hitShapes")] 
		public CArray<CName> HitShapes
		{
			get => GetProperty(ref _hitShapes);
			set => SetProperty(ref _hitShapes, value);
		}
	}
}

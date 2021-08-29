using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animImportFacialInitialPoseEntryDesc : RedBaseClass
	{
		private CName _poseName;
		private CInt16 _id;
		private CFloat _weight;
		private CUInt8 _type;
		private CUInt8 _side;
		private CBool _isCachable;
		private CFloat _initAnimationPoseMid;
		private CFloat _initAnimationPoseMin;
		private CFloat _initAnimationPoseMax;

		[Ordinal(0)] 
		[RED("poseName")] 
		public CName PoseName
		{
			get => GetProperty(ref _poseName);
			set => SetProperty(ref _poseName, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(4)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get => GetProperty(ref _side);
			set => SetProperty(ref _side, value);
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get => GetProperty(ref _isCachable);
			set => SetProperty(ref _isCachable, value);
		}

		[Ordinal(6)] 
		[RED("initAnimationPoseMid")] 
		public CFloat InitAnimationPoseMid
		{
			get => GetProperty(ref _initAnimationPoseMid);
			set => SetProperty(ref _initAnimationPoseMid, value);
		}

		[Ordinal(7)] 
		[RED("initAnimationPoseMin")] 
		public CFloat InitAnimationPoseMin
		{
			get => GetProperty(ref _initAnimationPoseMin);
			set => SetProperty(ref _initAnimationPoseMin, value);
		}

		[Ordinal(8)] 
		[RED("initAnimationPoseMax")] 
		public CFloat InitAnimationPoseMax
		{
			get => GetProperty(ref _initAnimationPoseMax);
			set => SetProperty(ref _initAnimationPoseMax, value);
		}
	}
}

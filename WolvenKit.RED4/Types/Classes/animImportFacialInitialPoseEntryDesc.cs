using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animImportFacialInitialPoseEntryDesc : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("poseName")] 
		public CName PoseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CInt16 Id
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CUInt8 Type
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(4)] 
		[RED("side")] 
		public CUInt8 Side
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(5)] 
		[RED("isCachable")] 
		public CBool IsCachable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("initAnimationPoseMid")] 
		public CFloat InitAnimationPoseMid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("initAnimationPoseMin")] 
		public CFloat InitAnimationPoseMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("initAnimationPoseMax")] 
		public CFloat InitAnimationPoseMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animImportFacialInitialPoseEntryDesc()
		{
			Id = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

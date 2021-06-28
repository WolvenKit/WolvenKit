using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHumanoidBody : entIComponent
	{
		private CFloat _basePersonalSpace;
		private CFloat _baseHeight;
		private CFloat _baseEyesHeightRatio;
		private CName _stanceAnimFeatureName;
		private CName _aimAnimFeatureName;

		[Ordinal(3)] 
		[RED("basePersonalSpace")] 
		public CFloat BasePersonalSpace
		{
			get => GetProperty(ref _basePersonalSpace);
			set => SetProperty(ref _basePersonalSpace, value);
		}

		[Ordinal(4)] 
		[RED("baseHeight")] 
		public CFloat BaseHeight
		{
			get => GetProperty(ref _baseHeight);
			set => SetProperty(ref _baseHeight, value);
		}

		[Ordinal(5)] 
		[RED("baseEyesHeightRatio")] 
		public CFloat BaseEyesHeightRatio
		{
			get => GetProperty(ref _baseEyesHeightRatio);
			set => SetProperty(ref _baseEyesHeightRatio, value);
		}

		[Ordinal(6)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get => GetProperty(ref _stanceAnimFeatureName);
			set => SetProperty(ref _stanceAnimFeatureName, value);
		}

		[Ordinal(7)] 
		[RED("aimAnimFeatureName")] 
		public CName AimAnimFeatureName
		{
			get => GetProperty(ref _aimAnimFeatureName);
			set => SetProperty(ref _aimAnimFeatureName, value);
		}

		public gameHumanoidBody(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

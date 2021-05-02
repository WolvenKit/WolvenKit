using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerCover : animAnimFeature
	{
		private Vector4 _cameraPositionMS;
		private CInt32 _coverState;
		private CFloat _leanAmount;
		private CFloat _cameraOffsetAmount;
		private CBool _autoCoverActivationFrame;

		[Ordinal(0)] 
		[RED("cameraPositionMS")] 
		public Vector4 CameraPositionMS
		{
			get => GetProperty(ref _cameraPositionMS);
			set => SetProperty(ref _cameraPositionMS, value);
		}

		[Ordinal(1)] 
		[RED("coverState")] 
		public CInt32 CoverState
		{
			get => GetProperty(ref _coverState);
			set => SetProperty(ref _coverState, value);
		}

		[Ordinal(2)] 
		[RED("leanAmount")] 
		public CFloat LeanAmount
		{
			get => GetProperty(ref _leanAmount);
			set => SetProperty(ref _leanAmount, value);
		}

		[Ordinal(3)] 
		[RED("cameraOffsetAmount")] 
		public CFloat CameraOffsetAmount
		{
			get => GetProperty(ref _cameraOffsetAmount);
			set => SetProperty(ref _cameraOffsetAmount, value);
		}

		[Ordinal(4)] 
		[RED("autoCoverActivationFrame")] 
		public CBool AutoCoverActivationFrame
		{
			get => GetProperty(ref _autoCoverActivationFrame);
			set => SetProperty(ref _autoCoverActivationFrame, value);
		}

		public animAnimFeature_PlayerCover(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

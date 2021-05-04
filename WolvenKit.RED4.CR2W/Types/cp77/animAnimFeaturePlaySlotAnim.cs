using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeaturePlaySlotAnim : animAnimFeature
	{
		private CName _slotName;
		private CName _animationName;
		private CFloat _blendInTime;
		private CFloat _blendOutTime;
		private CFloat _speedMultiplier;
		private CFloat _startOffsetRelative;
		private CBool _playAsAdditive;
		private CBool _enableMotion;
		private CInt32 _numberOfLoops;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(1)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(2)] 
		[RED("blendInTime")] 
		public CFloat BlendInTime
		{
			get => GetProperty(ref _blendInTime);
			set => SetProperty(ref _blendInTime, value);
		}

		[Ordinal(3)] 
		[RED("blendOutTime")] 
		public CFloat BlendOutTime
		{
			get => GetProperty(ref _blendOutTime);
			set => SetProperty(ref _blendOutTime, value);
		}

		[Ordinal(4)] 
		[RED("speedMultiplier")] 
		public CFloat SpeedMultiplier
		{
			get => GetProperty(ref _speedMultiplier);
			set => SetProperty(ref _speedMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("startOffsetRelative")] 
		public CFloat StartOffsetRelative
		{
			get => GetProperty(ref _startOffsetRelative);
			set => SetProperty(ref _startOffsetRelative, value);
		}

		[Ordinal(6)] 
		[RED("playAsAdditive")] 
		public CBool PlayAsAdditive
		{
			get => GetProperty(ref _playAsAdditive);
			set => SetProperty(ref _playAsAdditive, value);
		}

		[Ordinal(7)] 
		[RED("enableMotion")] 
		public CBool EnableMotion
		{
			get => GetProperty(ref _enableMotion);
			set => SetProperty(ref _enableMotion, value);
		}

		[Ordinal(8)] 
		[RED("numberOfLoops")] 
		public CInt32 NumberOfLoops
		{
			get => GetProperty(ref _numberOfLoops);
			set => SetProperty(ref _numberOfLoops, value);
		}

		public animAnimFeaturePlaySlotAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

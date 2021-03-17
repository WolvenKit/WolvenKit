using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RoadBlock : animAnimFeature
	{
		private CBool _isOpening;
		private CFloat _duration;
		private CBool _initOpen;

		[Ordinal(0)] 
		[RED("isOpening")] 
		public CBool IsOpening
		{
			get => GetProperty(ref _isOpening);
			set => SetProperty(ref _isOpening, value);
		}

		[Ordinal(1)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(2)] 
		[RED("initOpen")] 
		public CBool InitOpen
		{
			get => GetProperty(ref _initOpen);
			set => SetProperty(ref _initOpen, value);
		}

		public AnimFeature_RoadBlock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

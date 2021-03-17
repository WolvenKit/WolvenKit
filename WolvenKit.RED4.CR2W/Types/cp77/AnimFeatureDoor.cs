using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeatureDoor : animAnimFeature
	{
		private CFloat _progress;
		private CFloat _openingSpeed;
		private CInt32 _openingType;
		private CInt32 _doorSide;

		[Ordinal(0)] 
		[RED("progress")] 
		public CFloat Progress
		{
			get => GetProperty(ref _progress);
			set => SetProperty(ref _progress, value);
		}

		[Ordinal(1)] 
		[RED("openingSpeed")] 
		public CFloat OpeningSpeed
		{
			get => GetProperty(ref _openingSpeed);
			set => SetProperty(ref _openingSpeed, value);
		}

		[Ordinal(2)] 
		[RED("openingType")] 
		public CInt32 OpeningType
		{
			get => GetProperty(ref _openingType);
			set => SetProperty(ref _openingType, value);
		}

		[Ordinal(3)] 
		[RED("doorSide")] 
		public CInt32 DoorSide
		{
			get => GetProperty(ref _doorSide);
			set => SetProperty(ref _doorSide, value);
		}

		public AnimFeatureDoor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

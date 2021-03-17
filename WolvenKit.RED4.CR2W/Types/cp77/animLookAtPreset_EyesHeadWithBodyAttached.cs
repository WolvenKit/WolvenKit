using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_EyesHeadWithBodyAttached : animLookAtPreset
	{
		private CFloat _suppressHeadAnimation;
		private CFloat _headMobility;
		private CFloat _suppressChestAnimation;
		private CFloat _chestMobility;
		private CFloat _softLimitAngle;

		[Ordinal(0)] 
		[RED("suppressHeadAnimation")] 
		public CFloat SuppressHeadAnimation
		{
			get => GetProperty(ref _suppressHeadAnimation);
			set => SetProperty(ref _suppressHeadAnimation, value);
		}

		[Ordinal(1)] 
		[RED("headMobility")] 
		public CFloat HeadMobility
		{
			get => GetProperty(ref _headMobility);
			set => SetProperty(ref _headMobility, value);
		}

		[Ordinal(2)] 
		[RED("suppressChestAnimation")] 
		public CFloat SuppressChestAnimation
		{
			get => GetProperty(ref _suppressChestAnimation);
			set => SetProperty(ref _suppressChestAnimation, value);
		}

		[Ordinal(3)] 
		[RED("chestMobility")] 
		public CFloat ChestMobility
		{
			get => GetProperty(ref _chestMobility);
			set => SetProperty(ref _chestMobility, value);
		}

		[Ordinal(4)] 
		[RED("softLimitAngle")] 
		public CFloat SoftLimitAngle
		{
			get => GetProperty(ref _softLimitAngle);
			set => SetProperty(ref _softLimitAngle, value);
		}

		public animLookAtPreset_EyesHeadWithBodyAttached(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

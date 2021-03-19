using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_Landing : animAnimFeature
	{
		private CInt32 _type;
		private CFloat _impactSpeed;

		[Ordinal(0)] 
		[RED("type")] 
		public CInt32 Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("impactSpeed")] 
		public CFloat ImpactSpeed
		{
			get => GetProperty(ref _impactSpeed);
			set => SetProperty(ref _impactSpeed, value);
		}

		public AnimFeature_Landing(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

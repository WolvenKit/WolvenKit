using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidAnimationContainerSRRefAnimContainerContext : CVariable
	{
		private scnGenderMask _genderMask;

		[Ordinal(0)] 
		[RED("genderMask")] 
		public scnGenderMask GenderMask
		{
			get => GetProperty(ref _genderMask);
			set => SetProperty(ref _genderMask, value);
		}

		public scnRidAnimationContainerSRRefAnimContainerContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

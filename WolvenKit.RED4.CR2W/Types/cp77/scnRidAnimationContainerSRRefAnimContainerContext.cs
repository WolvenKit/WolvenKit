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
			get
			{
				if (_genderMask == null)
				{
					_genderMask = (scnGenderMask) CR2WTypeManager.Create("scnGenderMask", "genderMask", cr2w, this);
				}
				return _genderMask;
			}
			set
			{
				if (_genderMask == value)
				{
					return;
				}
				_genderMask = value;
				PropertySet(this);
			}
		}

		public scnRidAnimationContainerSRRefAnimContainerContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

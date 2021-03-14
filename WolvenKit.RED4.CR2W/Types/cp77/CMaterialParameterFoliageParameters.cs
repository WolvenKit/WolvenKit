using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterFoliageParameters : CMaterialParameter
	{
		private rRef<CFoliageProfile> _foliageProfile;

		[Ordinal(2)] 
		[RED("foliageProfile")] 
		public rRef<CFoliageProfile> FoliageProfile
		{
			get
			{
				if (_foliageProfile == null)
				{
					_foliageProfile = (rRef<CFoliageProfile>) CR2WTypeManager.Create("rRef:CFoliageProfile", "foliageProfile", cr2w, this);
				}
				return _foliageProfile;
			}
			set
			{
				if (_foliageProfile == value)
				{
					return;
				}
				_foliageProfile = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterFoliageParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

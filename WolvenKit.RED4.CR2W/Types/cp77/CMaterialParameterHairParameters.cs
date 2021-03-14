using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterHairParameters : CMaterialParameter
	{
		private rRef<CHairProfile> _hairProfile;

		[Ordinal(2)] 
		[RED("hairProfile")] 
		public rRef<CHairProfile> HairProfile
		{
			get
			{
				if (_hairProfile == null)
				{
					_hairProfile = (rRef<CHairProfile>) CR2WTypeManager.Create("rRef:CHairProfile", "hairProfile", cr2w, this);
				}
				return _hairProfile;
			}
			set
			{
				if (_hairProfile == value)
				{
					return;
				}
				_hairProfile = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterHairParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

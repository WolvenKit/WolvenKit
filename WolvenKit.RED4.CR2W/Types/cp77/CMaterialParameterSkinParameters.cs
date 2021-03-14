using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterSkinParameters : CMaterialParameter
	{
		private rRef<CSkinProfile> _skinProfile;

		[Ordinal(2)] 
		[RED("skinProfile")] 
		public rRef<CSkinProfile> SkinProfile
		{
			get
			{
				if (_skinProfile == null)
				{
					_skinProfile = (rRef<CSkinProfile>) CR2WTypeManager.Create("rRef:CSkinProfile", "skinProfile", cr2w, this);
				}
				return _skinProfile;
			}
			set
			{
				if (_skinProfile == value)
				{
					return;
				}
				_skinProfile = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterSkinParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

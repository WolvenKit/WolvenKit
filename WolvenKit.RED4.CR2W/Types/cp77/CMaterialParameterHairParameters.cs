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
			get => GetProperty(ref _hairProfile);
			set => SetProperty(ref _hairProfile, value);
		}

		public CMaterialParameterHairParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

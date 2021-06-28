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
			get => GetProperty(ref _skinProfile);
			set => SetProperty(ref _skinProfile, value);
		}

		public CMaterialParameterSkinParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

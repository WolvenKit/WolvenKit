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
			get => GetProperty(ref _foliageProfile);
			set => SetProperty(ref _foliageProfile, value);
		}

		public CMaterialParameterFoliageParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

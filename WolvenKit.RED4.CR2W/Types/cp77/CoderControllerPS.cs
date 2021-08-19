using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CoderControllerPS : BasicDistractionDeviceControllerPS
	{
		private CEnum<ESecurityAccessLevel> _providedAuthorizationLevel;

		[Ordinal(109)] 
		[RED("providedAuthorizationLevel")] 
		public CEnum<ESecurityAccessLevel> ProvidedAuthorizationLevel
		{
			get => GetProperty(ref _providedAuthorizationLevel);
			set => SetProperty(ref _providedAuthorizationLevel, value);
		}

		public CoderControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

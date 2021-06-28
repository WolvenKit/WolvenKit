using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemClearanceEntry : CVariable
	{
		private entEntityID _user;
		private CEnum<ESecurityAccessLevel> _level;

		[Ordinal(0)] 
		[RED("user")] 
		public entEntityID User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(1)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public SecuritySystemClearanceEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

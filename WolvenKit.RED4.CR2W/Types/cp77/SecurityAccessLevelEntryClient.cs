using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
	{
		private CEnum<ESecurityAccessLevel> _level;

		[Ordinal(2)] 
		[RED("level")] 
		public CEnum<ESecurityAccessLevel> Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public SecurityAccessLevelEntryClient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

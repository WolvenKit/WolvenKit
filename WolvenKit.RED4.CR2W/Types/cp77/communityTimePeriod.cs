using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityTimePeriod : CVariable
	{
		private CEnum<communityECommunitySpawnTime> _hour;

		[Ordinal(0)] 
		[RED("hour")] 
		public CEnum<communityECommunitySpawnTime> Hour
		{
			get => GetProperty(ref _hour);
			set => SetProperty(ref _hour, value);
		}

		public communityTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

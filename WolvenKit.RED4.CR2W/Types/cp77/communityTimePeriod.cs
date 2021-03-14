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
			get
			{
				if (_hour == null)
				{
					_hour = (CEnum<communityECommunitySpawnTime>) CR2WTypeManager.Create("communityECommunitySpawnTime", "hour", cr2w, this);
				}
				return _hour;
			}
			set
			{
				if (_hour == value)
				{
					return;
				}
				_hour = value;
				PropertySet(this);
			}
		}

		public communityTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

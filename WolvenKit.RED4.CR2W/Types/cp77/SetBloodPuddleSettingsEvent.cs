using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetBloodPuddleSettingsEvent : redEvent
	{
		private CBool _shouldSpawnBloodPuddle;

		[Ordinal(0)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get
			{
				if (_shouldSpawnBloodPuddle == null)
				{
					_shouldSpawnBloodPuddle = (CBool) CR2WTypeManager.Create("Bool", "shouldSpawnBloodPuddle", cr2w, this);
				}
				return _shouldSpawnBloodPuddle;
			}
			set
			{
				if (_shouldSpawnBloodPuddle == value)
				{
					return;
				}
				_shouldSpawnBloodPuddle = value;
				PropertySet(this);
			}
		}

		public SetBloodPuddleSettingsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

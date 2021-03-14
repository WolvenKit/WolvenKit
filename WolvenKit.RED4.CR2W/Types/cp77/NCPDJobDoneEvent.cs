using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NCPDJobDoneEvent : redEvent
	{
		private CInt32 _levelXPAwarded;
		private CInt32 _streetCredXPAwarded;

		[Ordinal(0)] 
		[RED("levelXPAwarded")] 
		public CInt32 LevelXPAwarded
		{
			get
			{
				if (_levelXPAwarded == null)
				{
					_levelXPAwarded = (CInt32) CR2WTypeManager.Create("Int32", "levelXPAwarded", cr2w, this);
				}
				return _levelXPAwarded;
			}
			set
			{
				if (_levelXPAwarded == value)
				{
					return;
				}
				_levelXPAwarded = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("streetCredXPAwarded")] 
		public CInt32 StreetCredXPAwarded
		{
			get
			{
				if (_streetCredXPAwarded == null)
				{
					_streetCredXPAwarded = (CInt32) CR2WTypeManager.Create("Int32", "streetCredXPAwarded", cr2w, this);
				}
				return _streetCredXPAwarded;
			}
			set
			{
				if (_streetCredXPAwarded == value)
				{
					return;
				}
				_streetCredXPAwarded = value;
				PropertySet(this);
			}
		}

		public NCPDJobDoneEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

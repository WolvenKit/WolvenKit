using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetQuestTargetWasSeen : redEvent
	{
		private CBool _wasSeen;

		[Ordinal(0)] 
		[RED("wasSeen")] 
		public CBool WasSeen
		{
			get
			{
				if (_wasSeen == null)
				{
					_wasSeen = (CBool) CR2WTypeManager.Create("Bool", "wasSeen", cr2w, this);
				}
				return _wasSeen;
			}
			set
			{
				if (_wasSeen == value)
				{
					return;
				}
				_wasSeen = value;
				PropertySet(this);
			}
		}

		public SetQuestTargetWasSeen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

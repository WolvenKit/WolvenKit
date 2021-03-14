using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedJournalUpdate : redEvent
	{
		private CBool _newMessageSpawned;

		[Ordinal(0)] 
		[RED("newMessageSpawned")] 
		public CBool NewMessageSpawned
		{
			get
			{
				if (_newMessageSpawned == null)
				{
					_newMessageSpawned = (CBool) CR2WTypeManager.Create("Bool", "newMessageSpawned", cr2w, this);
				}
				return _newMessageSpawned;
			}
			set
			{
				if (_newMessageSpawned == value)
				{
					return;
				}
				_newMessageSpawned = value;
				PropertySet(this);
			}
		}

		public DelayedJournalUpdate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

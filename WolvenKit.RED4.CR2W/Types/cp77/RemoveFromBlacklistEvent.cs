using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RemoveFromBlacklistEvent : redEvent
	{
		private entEntityID _entityIDToRemove;

		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
		{
			get
			{
				if (_entityIDToRemove == null)
				{
					_entityIDToRemove = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityIDToRemove", cr2w, this);
				}
				return _entityIDToRemove;
			}
			set
			{
				if (_entityIDToRemove == value)
				{
					return;
				}
				_entityIDToRemove = value;
				PropertySet(this);
			}
		}

		public RemoveFromBlacklistEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

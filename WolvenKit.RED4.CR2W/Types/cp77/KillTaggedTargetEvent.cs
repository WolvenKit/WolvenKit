using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KillTaggedTargetEvent : redEvent
	{
		private wCHandle<gameObject> _taggedObject;

		[Ordinal(0)] 
		[RED("taggedObject")] 
		public wCHandle<gameObject> TaggedObject
		{
			get
			{
				if (_taggedObject == null)
				{
					_taggedObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "taggedObject", cr2w, this);
				}
				return _taggedObject;
			}
			set
			{
				if (_taggedObject == value)
				{
					return;
				}
				_taggedObject = value;
				PropertySet(this);
			}
		}

		public KillTaggedTargetEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

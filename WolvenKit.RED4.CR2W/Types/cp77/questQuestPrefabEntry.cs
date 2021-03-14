using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questQuestPrefabEntry : CVariable
	{
		private NodeRef _prefabNodeRef;

		[Ordinal(0)] 
		[RED("prefabNodeRef")] 
		public NodeRef PrefabNodeRef
		{
			get
			{
				if (_prefabNodeRef == null)
				{
					_prefabNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "prefabNodeRef", cr2w, this);
				}
				return _prefabNodeRef;
			}
			set
			{
				if (_prefabNodeRef == value)
				{
					return;
				}
				_prefabNodeRef = value;
				PropertySet(this);
			}
		}

		public questQuestPrefabEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		private CName _groupKey;

		[Ordinal(6)] 
		[RED("groupKey")] 
		public CName GroupKey
		{
			get
			{
				if (_groupKey == null)
				{
					_groupKey = (CName) CR2WTypeManager.Create("CName", "groupKey", cr2w, this);
				}
				return _groupKey;
			}
			set
			{
				if (_groupKey == value)
				{
					return;
				}
				_groupKey = value;
				PropertySet(this);
			}
		}

		public worldAIDirectorSpawnAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

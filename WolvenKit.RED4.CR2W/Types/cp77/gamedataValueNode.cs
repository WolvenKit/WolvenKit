using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataValueNode : gamedataDataNode
	{
		private CHandle<gamedataValueDataNode> _data;
		private CHandle<gamedataGroupNode> _group;

		[Ordinal(3)] 
		[RED("data")] 
		public CHandle<gamedataValueDataNode> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<gamedataValueDataNode>) CR2WTypeManager.Create("handle:gamedataValueDataNode", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("group")] 
		public CHandle<gamedataGroupNode> Group
		{
			get
			{
				if (_group == null)
				{
					_group = (CHandle<gamedataGroupNode>) CR2WTypeManager.Create("handle:gamedataGroupNode", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		public gamedataValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

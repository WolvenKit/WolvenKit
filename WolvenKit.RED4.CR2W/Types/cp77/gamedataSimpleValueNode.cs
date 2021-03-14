using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataSimpleValueNode : gamedataValueDataNode
	{
		private CEnum<gamedataSimpleValueNodeValueType> _type;
		private CString _data;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<gamedataSimpleValueNodeValueType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gamedataSimpleValueNodeValueType>) CR2WTypeManager.Create("gamedataSimpleValueNodeValueType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CString Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CString) CR2WTypeManager.Create("String", "data", cr2w, this);
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

		public gamedataSimpleValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataVariableNodeVariableValue : CVariable
	{
		private CHandle<gamedataValueNode> _node;
		private CEnum<gamedataVariableNodeVariableValueDeriveInfo> _deriveInfo;

		[Ordinal(0)] 
		[RED("node")] 
		public CHandle<gamedataValueNode> Node
		{
			get
			{
				if (_node == null)
				{
					_node = (CHandle<gamedataValueNode>) CR2WTypeManager.Create("handle:gamedataValueNode", "node", cr2w, this);
				}
				return _node;
			}
			set
			{
				if (_node == value)
				{
					return;
				}
				_node = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataVariableNodeVariableValueDeriveInfo> DeriveInfo
		{
			get
			{
				if (_deriveInfo == null)
				{
					_deriveInfo = (CEnum<gamedataVariableNodeVariableValueDeriveInfo>) CR2WTypeManager.Create("gamedataVariableNodeVariableValueDeriveInfo", "deriveInfo", cr2w, this);
				}
				return _deriveInfo;
			}
			set
			{
				if (_deriveInfo == value)
				{
					return;
				}
				_deriveInfo = value;
				PropertySet(this);
			}
		}

		public gamedataVariableNodeVariableValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

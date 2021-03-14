using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataGroupNodeGroupVariable : CVariable
	{
		private CHandle<gamedataVariableNode> _node;
		private CEnum<gamedataGroupNodeGroupVariableDeriveInfo> _deriveInfo;
		private CBool _flattened;
		private TweakDBID _flatId;

		[Ordinal(0)] 
		[RED("node")] 
		public CHandle<gamedataVariableNode> Node
		{
			get
			{
				if (_node == null)
				{
					_node = (CHandle<gamedataVariableNode>) CR2WTypeManager.Create("handle:gamedataVariableNode", "node", cr2w, this);
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
		public CEnum<gamedataGroupNodeGroupVariableDeriveInfo> DeriveInfo
		{
			get
			{
				if (_deriveInfo == null)
				{
					_deriveInfo = (CEnum<gamedataGroupNodeGroupVariableDeriveInfo>) CR2WTypeManager.Create("gamedataGroupNodeGroupVariableDeriveInfo", "deriveInfo", cr2w, this);
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

		[Ordinal(2)] 
		[RED("flattened")] 
		public CBool Flattened
		{
			get
			{
				if (_flattened == null)
				{
					_flattened = (CBool) CR2WTypeManager.Create("Bool", "flattened", cr2w, this);
				}
				return _flattened;
			}
			set
			{
				if (_flattened == value)
				{
					return;
				}
				_flattened = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("flatId")] 
		public TweakDBID FlatId
		{
			get
			{
				if (_flatId == null)
				{
					_flatId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "flatId", cr2w, this);
				}
				return _flatId;
			}
			set
			{
				if (_flatId == value)
				{
					return;
				}
				_flatId = value;
				PropertySet(this);
			}
		}

		public gamedataGroupNodeGroupVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

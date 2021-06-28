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
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataVariableNodeVariableValueDeriveInfo> DeriveInfo
		{
			get => GetProperty(ref _deriveInfo);
			set => SetProperty(ref _deriveInfo, value);
		}

		public gamedataVariableNodeVariableValue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

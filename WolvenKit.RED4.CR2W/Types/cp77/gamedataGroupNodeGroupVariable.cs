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
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}

		[Ordinal(1)] 
		[RED("deriveInfo")] 
		public CEnum<gamedataGroupNodeGroupVariableDeriveInfo> DeriveInfo
		{
			get => GetProperty(ref _deriveInfo);
			set => SetProperty(ref _deriveInfo, value);
		}

		[Ordinal(2)] 
		[RED("flattened")] 
		public CBool Flattened
		{
			get => GetProperty(ref _flattened);
			set => SetProperty(ref _flattened, value);
		}

		[Ordinal(3)] 
		[RED("flatId")] 
		public TweakDBID FlatId
		{
			get => GetProperty(ref _flatId);
			set => SetProperty(ref _flatId, value);
		}

		public gamedataGroupNodeGroupVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

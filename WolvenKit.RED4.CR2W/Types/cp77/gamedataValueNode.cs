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
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("group")] 
		public CHandle<gamedataGroupNode> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		public gamedataValueNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataValueNode : gamedataDataNode
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
	}
}

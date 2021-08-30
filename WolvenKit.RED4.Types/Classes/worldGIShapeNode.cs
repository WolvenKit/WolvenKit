using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldGIShapeNode : worldGeometryShapeNode
	{
		private CUInt32 _priority;
		private CEnum<rendGIGroup> _group;
		private CBool _interior;
		private CBool _runtime;
		private CBool _updated;

		[Ordinal(6)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(7)] 
		[RED("group")] 
		public CEnum<rendGIGroup> Group
		{
			get => GetProperty(ref _group);
			set => SetProperty(ref _group, value);
		}

		[Ordinal(8)] 
		[RED("interior")] 
		public CBool Interior
		{
			get => GetProperty(ref _interior);
			set => SetProperty(ref _interior, value);
		}

		[Ordinal(9)] 
		[RED("runtime")] 
		public CBool Runtime
		{
			get => GetProperty(ref _runtime);
			set => SetProperty(ref _runtime, value);
		}

		[Ordinal(10)] 
		[RED("updated")] 
		public CBool Updated
		{
			get => GetProperty(ref _updated);
			set => SetProperty(ref _updated, value);
		}

		public worldGIShapeNode()
		{
			_priority = 1;
		}
	}
}

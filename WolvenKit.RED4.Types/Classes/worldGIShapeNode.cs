using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldGIShapeNode : worldGeometryShapeNode
	{
		[Ordinal(6)] 
		[RED("priority")] 
		public CUInt32 Priority
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("group")] 
		public CEnum<rendGIGroup> Group
		{
			get => GetPropertyValue<CEnum<rendGIGroup>>();
			set => SetPropertyValue<CEnum<rendGIGroup>>(value);
		}

		[Ordinal(8)] 
		[RED("interior")] 
		public CBool Interior
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("runtime")] 
		public CBool Runtime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("updated")] 
		public CBool Updated
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldGIShapeNode()
		{
			Priority = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

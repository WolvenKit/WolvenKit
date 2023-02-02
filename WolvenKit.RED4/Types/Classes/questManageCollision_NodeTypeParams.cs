using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questManageCollision_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public questManageCollision_NodeTypeParams()
		{
			EnableQueries = true;
			Components = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

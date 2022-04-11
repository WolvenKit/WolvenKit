using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_VectorJoin : animAnimNode_VectorValue
	{
		[Ordinal(11)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetPropertyValue<animVectorLink>();
			set => SetPropertyValue<animVectorLink>(value);
		}

		public animAnimNode_VectorJoin()
		{
			Id = 4294967295;
			Input = new();
		}
	}
}

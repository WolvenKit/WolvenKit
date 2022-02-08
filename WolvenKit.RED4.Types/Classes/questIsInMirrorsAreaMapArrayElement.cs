using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIsInMirrorsAreaMapArrayElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("isInMirrorsArea")] 
		public CBool IsInMirrorsArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

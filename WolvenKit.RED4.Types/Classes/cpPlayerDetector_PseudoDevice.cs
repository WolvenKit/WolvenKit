using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class cpPlayerDetector_PseudoDevice : gameObject
	{
		[Ordinal(35)] 
		[RED("playerDetector")] 
		public NodeRef PlayerDetector
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}

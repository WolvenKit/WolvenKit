using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCrowdNullAreaNode : worldAreaShapeNode
	{
		[Ordinal(6)] 
		[RED("IsForBlockade")] 
		public CBool IsForBlockade
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		private NodeRef _area;

		[Ordinal(0)] 
		[RED("area")] 
		public NodeRef Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_RestrictMovementToArea : questCombatNodeParams
	{
		private NodeRef _area;

		[Ordinal(0)] 
		[RED("area")] 
		public NodeRef Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		public questCombatNodeParams_RestrictMovementToArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

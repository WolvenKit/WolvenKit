using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAssignRoleCommandParams : questScriptedAICommandParams
	{
		[Ordinal(0)] 
		[RED("role")] 
		public CHandle<AIRole> Role
		{
			get => GetPropertyValue<CHandle<AIRole>>();
			set => SetPropertyValue<CHandle<AIRole>>(value);
		}
	}
}

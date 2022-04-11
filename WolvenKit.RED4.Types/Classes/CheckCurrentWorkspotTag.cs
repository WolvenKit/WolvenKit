using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentWorkspotTag : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CHandle<AIArgumentMapping> Tag
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}

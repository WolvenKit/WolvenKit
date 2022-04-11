using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorUnmountImmediatelyNodeDefinition : AIbehaviorDecoratorNodeDefinition
	{
		[Ordinal(1)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}

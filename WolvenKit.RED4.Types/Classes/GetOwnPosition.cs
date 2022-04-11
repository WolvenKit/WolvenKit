using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GetOwnPosition : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("outPosition")] 
		public CHandle<AIArgumentMapping> OutPosition
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}

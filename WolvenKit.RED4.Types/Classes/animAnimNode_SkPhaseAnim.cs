using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkPhaseAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] 
		[RED("phase")] 
		public CName Phase
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}

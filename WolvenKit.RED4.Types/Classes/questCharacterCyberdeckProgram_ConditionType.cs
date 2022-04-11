using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCyberdeckProgram_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("cyberdeckProgramID")] 
		public TweakDBID CyberdeckProgramID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

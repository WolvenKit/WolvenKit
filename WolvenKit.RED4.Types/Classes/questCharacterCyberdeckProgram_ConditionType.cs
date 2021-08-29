using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterCyberdeckProgram_ConditionType : questICharacterConditionType
	{
		private TweakDBID _cyberdeckProgramID;

		[Ordinal(0)] 
		[RED("cyberdeckProgramID")] 
		public TweakDBID CyberdeckProgramID
		{
			get => GetProperty(ref _cyberdeckProgramID);
			set => SetProperty(ref _cyberdeckProgramID, value);
		}
	}
}

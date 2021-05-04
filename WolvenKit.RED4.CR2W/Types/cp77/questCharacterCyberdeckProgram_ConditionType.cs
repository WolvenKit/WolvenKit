using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterCyberdeckProgram_ConditionType : questICharacterConditionType
	{
		private TweakDBID _cyberdeckProgramID;

		[Ordinal(0)] 
		[RED("cyberdeckProgramID")] 
		public TweakDBID CyberdeckProgramID
		{
			get => GetProperty(ref _cyberdeckProgramID);
			set => SetProperty(ref _cyberdeckProgramID, value);
		}

		public questCharacterCyberdeckProgram_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

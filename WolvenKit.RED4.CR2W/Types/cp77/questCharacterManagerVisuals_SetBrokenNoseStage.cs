using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerVisuals_SetBrokenNoseStage : questICharacterManagerVisuals_NodeSubType
	{
		private CEnum<gameuiCharacterCustomization_BrokenNoseStage> _brokenNoseStage;

		[Ordinal(0)] 
		[RED("brokenNoseStage")] 
		public CEnum<gameuiCharacterCustomization_BrokenNoseStage> BrokenNoseStage
		{
			get => GetProperty(ref _brokenNoseStage);
			set => SetProperty(ref _brokenNoseStage, value);
		}

		public questCharacterManagerVisuals_SetBrokenNoseStage(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

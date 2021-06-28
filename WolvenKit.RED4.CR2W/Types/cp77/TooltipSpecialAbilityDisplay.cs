using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipSpecialAbilityDisplay : inkWidgetLogicController
	{
		private inkImageWidgetReference _abilityIcon;
		private inkTextWidgetReference _abilityDescription;
		private inkWidgetReference _qualityRoot;

		[Ordinal(1)] 
		[RED("AbilityIcon")] 
		public inkImageWidgetReference AbilityIcon
		{
			get => GetProperty(ref _abilityIcon);
			set => SetProperty(ref _abilityIcon, value);
		}

		[Ordinal(2)] 
		[RED("AbilityDescription")] 
		public inkTextWidgetReference AbilityDescription
		{
			get => GetProperty(ref _abilityDescription);
			set => SetProperty(ref _abilityDescription, value);
		}

		[Ordinal(3)] 
		[RED("QualityRoot")] 
		public inkWidgetReference QualityRoot
		{
			get => GetProperty(ref _qualityRoot);
			set => SetProperty(ref _qualityRoot, value);
		}

		public TooltipSpecialAbilityDisplay(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

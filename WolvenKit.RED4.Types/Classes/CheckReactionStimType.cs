using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckReactionStimType : AIbehaviorconditionScript
	{
		[Ordinal(0)] 
		[RED("stimToCompare")] 
		public CEnum<gamedataStimType> StimToCompare
		{
			get => GetPropertyValue<CEnum<gamedataStimType>>();
			set => SetPropertyValue<CEnum<gamedataStimType>>(value);
		}
	}
}

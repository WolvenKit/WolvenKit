using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		[Ordinal(2)] 
		[RED("isFinalRemoval")] 
		public CBool IsFinalRemoval
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

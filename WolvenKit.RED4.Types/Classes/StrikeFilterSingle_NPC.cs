using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)] 
		[RED("onlyAlive")] 
		public CBool OnlyAlive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("onlyEnemies")] 
		public CBool OnlyEnemies
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

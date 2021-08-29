using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCpoArmouryItem : gameObject
	{
		private TweakDBID _armouryItemID;

		[Ordinal(40)] 
		[RED("armouryItemID")] 
		public TweakDBID ArmouryItemID
		{
			get => GetProperty(ref _armouryItemID);
			set => SetProperty(ref _armouryItemID, value);
		}
	}
}

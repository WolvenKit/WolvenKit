using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class parameterRequestEquip : IScriptable
	{
		[Ordinal(0)] 
		[RED("valid")] 
		public CBool Valid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public parameterRequestEquip()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}

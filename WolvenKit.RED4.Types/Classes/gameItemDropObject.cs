using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameItemDropObject : gameLootObject
	{
		[Ordinal(43)] 
		[RED("wasItemInitialized")] 
		public CBool WasItemInitialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}

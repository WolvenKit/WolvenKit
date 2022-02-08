using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameContainerObjectSingleItem : gameContainerObjectBase
	{
		[Ordinal(51)] 
		[RED("itemTDBID")] 
		public TweakDBID ItemTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubCharUnequipRequest : UnequipRequest
	{
		[Ordinal(3)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetPropertyValue<CEnum<gamedataSubCharacter>>();
			set => SetPropertyValue<CEnum<gamedataSubCharacter>>(value);
		}
	}
}

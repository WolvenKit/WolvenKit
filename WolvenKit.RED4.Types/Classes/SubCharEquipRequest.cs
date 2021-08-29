using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubCharEquipRequest : gameEquipRequest
	{
		private CEnum<gamedataSubCharacter> _subCharType;

		[Ordinal(5)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetProperty(ref _subCharType);
			set => SetProperty(ref _subCharType, value);
		}
	}
}

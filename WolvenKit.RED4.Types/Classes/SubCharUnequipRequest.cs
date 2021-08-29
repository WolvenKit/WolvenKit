using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubCharUnequipRequest : UnequipRequest
	{
		private CEnum<gamedataSubCharacter> _subCharType;

		[Ordinal(3)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get => GetProperty(ref _subCharType);
			set => SetProperty(ref _subCharType, value);
		}
	}
}

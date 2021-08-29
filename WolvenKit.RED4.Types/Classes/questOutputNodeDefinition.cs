using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questOutputNodeDefinition : questIONodeDefinition
	{
		private CEnum<questExitType> _type;

		[Ordinal(3)] 
		[RED("type")] 
		public CEnum<questExitType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}

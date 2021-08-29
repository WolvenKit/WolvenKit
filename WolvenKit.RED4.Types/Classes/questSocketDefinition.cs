using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSocketDefinition : graphGraphSocketDefinition
	{
		private CEnum<questSocketType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<questSocketType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}

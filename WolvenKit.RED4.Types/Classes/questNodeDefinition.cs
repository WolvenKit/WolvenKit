using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNodeDefinition : graphGraphNodeDefinition
	{
		[Ordinal(1)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}
	}
}

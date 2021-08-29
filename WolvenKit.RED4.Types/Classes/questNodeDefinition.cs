using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questNodeDefinition : graphGraphNodeDefinition
	{
		private CUInt16 _id;

		[Ordinal(1)] 
		[RED("id")] 
		public CUInt16 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}
	}
}

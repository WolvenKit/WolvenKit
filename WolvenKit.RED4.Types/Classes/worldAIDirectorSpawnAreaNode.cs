using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldAIDirectorSpawnAreaNode : worldAreaShapeNode
	{
		private CName _groupKey;

		[Ordinal(6)] 
		[RED("groupKey")] 
		public CName GroupKey
		{
			get => GetProperty(ref _groupKey);
			set => SetProperty(ref _groupKey, value);
		}
	}
}

using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficCompiledNode : worldNode
	{
		private Box _aabb;

		[Ordinal(4)] 
		[RED("aabb")] 
		public Box Aabb
		{
			get => GetProperty(ref _aabb);
			set => SetProperty(ref _aabb, value);
		}
	}
}

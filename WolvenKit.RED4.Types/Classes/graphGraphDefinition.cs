using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphDefinition : graphIGraphObjectDefinition
	{
		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<CHandle<graphGraphNodeDefinition>> Nodes
		{
			get => GetPropertyValue<CArray<CHandle<graphGraphNodeDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<graphGraphNodeDefinition>>>(value);
		}
	}
}

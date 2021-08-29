using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorParameterizedBehavior : ISerializable
	{
		private CResourceReference<AIbehaviorResource> _treeDefinition;
		private CArray<AIArgumentOverrideWrapper> _argumentsOverrides;

		[Ordinal(0)] 
		[RED("treeDefinition")] 
		public CResourceReference<AIbehaviorResource> TreeDefinition
		{
			get => GetProperty(ref _treeDefinition);
			set => SetProperty(ref _treeDefinition, value);
		}

		[Ordinal(1)] 
		[RED("argumentsOverrides")] 
		public CArray<AIArgumentOverrideWrapper> ArgumentsOverrides
		{
			get => GetProperty(ref _argumentsOverrides);
			set => SetProperty(ref _argumentsOverrides, value);
		}
	}
}

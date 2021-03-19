using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorParameterizedBehavior : ISerializable
	{
		private rRef<AIbehaviorResource> _treeDefinition;
		private CArray<AIArgumentOverrideWrapper> _argumentsOverrides;

		[Ordinal(0)] 
		[RED("treeDefinition")] 
		public rRef<AIbehaviorResource> TreeDefinition
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

		public AIbehaviorParameterizedBehavior(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

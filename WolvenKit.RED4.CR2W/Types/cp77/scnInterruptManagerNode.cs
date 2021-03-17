using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInterruptManagerNode : scnSceneGraphNode
	{
		private CArray<CHandle<scnIInterruptionOperation>> _interruptionOperations;

		[Ordinal(3)] 
		[RED("interruptionOperations")] 
		public CArray<CHandle<scnIInterruptionOperation>> InterruptionOperations
		{
			get => GetProperty(ref _interruptionOperations);
			set => SetProperty(ref _interruptionOperations, value);
		}

		public scnInterruptManagerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

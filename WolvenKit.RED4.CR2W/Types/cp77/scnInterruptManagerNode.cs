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
			get
			{
				if (_interruptionOperations == null)
				{
					_interruptionOperations = (CArray<CHandle<scnIInterruptionOperation>>) CR2WTypeManager.Create("array:handle:scnIInterruptionOperation", "interruptionOperations", cr2w, this);
				}
				return _interruptionOperations;
			}
			set
			{
				if (_interruptionOperations == value)
				{
					return;
				}
				_interruptionOperations = value;
				PropertySet(this);
			}
		}

		public scnInterruptManagerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

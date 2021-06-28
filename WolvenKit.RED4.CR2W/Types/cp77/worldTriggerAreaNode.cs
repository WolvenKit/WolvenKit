using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTriggerAreaNode : worldAreaShapeNode
	{
		private CArray<CHandle<worldITriggerAreaNotifer>> _notifiers;

		[Ordinal(6)] 
		[RED("notifiers")] 
		public CArray<CHandle<worldITriggerAreaNotifer>> Notifiers
		{
			get => GetProperty(ref _notifiers);
			set => SetProperty(ref _notifiers, value);
		}

		public worldTriggerAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

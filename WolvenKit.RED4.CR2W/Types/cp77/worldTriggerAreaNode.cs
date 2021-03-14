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
			get
			{
				if (_notifiers == null)
				{
					_notifiers = (CArray<CHandle<worldITriggerAreaNotifer>>) CR2WTypeManager.Create("array:handle:worldITriggerAreaNotifer", "notifiers", cr2w, this);
				}
				return _notifiers;
			}
			set
			{
				if (_notifiers == value)
				{
					return;
				}
				_notifiers = value;
				PropertySet(this);
			}
		}

		public worldTriggerAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

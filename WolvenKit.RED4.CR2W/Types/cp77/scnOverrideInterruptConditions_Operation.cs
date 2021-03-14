using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverrideInterruptConditions_Operation : scnIInterruptManager_Operation
	{
		private CArray<CHandle<scnIInterruptCondition>> _interruptConditions;

		[Ordinal(0)] 
		[RED("interruptConditions")] 
		public CArray<CHandle<scnIInterruptCondition>> InterruptConditions
		{
			get
			{
				if (_interruptConditions == null)
				{
					_interruptConditions = (CArray<CHandle<scnIInterruptCondition>>) CR2WTypeManager.Create("array:handle:scnIInterruptCondition", "interruptConditions", cr2w, this);
				}
				return _interruptConditions;
			}
			set
			{
				if (_interruptConditions == value)
				{
					return;
				}
				_interruptConditions = value;
				PropertySet(this);
			}
		}

		public scnOverrideInterruptConditions_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

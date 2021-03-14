using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnOverrideReturnConditions_Operation : scnIInterruptManager_Operation
	{
		private CArray<CHandle<scnIReturnCondition>> _returnConditions;

		[Ordinal(0)] 
		[RED("returnConditions")] 
		public CArray<CHandle<scnIReturnCondition>> ReturnConditions
		{
			get
			{
				if (_returnConditions == null)
				{
					_returnConditions = (CArray<CHandle<scnIReturnCondition>>) CR2WTypeManager.Create("array:handle:scnIReturnCondition", "returnConditions", cr2w, this);
				}
				return _returnConditions;
			}
			set
			{
				if (_returnConditions == value)
				{
					return;
				}
				_returnConditions = value;
				PropertySet(this);
			}
		}

		public scnOverrideReturnConditions_Operation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

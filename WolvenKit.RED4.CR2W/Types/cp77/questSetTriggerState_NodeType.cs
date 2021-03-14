using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetTriggerState_NodeType : questITriggerManagerNodeType
	{
		private CArray<questSetTriggerState_NodeTypeParams> _params;

		[Ordinal(0)] 
		[RED("params")] 
		public CArray<questSetTriggerState_NodeTypeParams> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<questSetTriggerState_NodeTypeParams>) CR2WTypeManager.Create("array:questSetTriggerState_NodeTypeParams", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		public questSetTriggerState_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

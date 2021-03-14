using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeTypeParams : CVariable
	{
		private CHandle<questUniversalRef> _objectRef;
		private CArray<questInjectLoot_NodeTypeParams_OperationData> _operations;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public CHandle<questUniversalRef> ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operations")] 
		public CArray<questInjectLoot_NodeTypeParams_OperationData> Operations
		{
			get
			{
				if (_operations == null)
				{
					_operations = (CArray<questInjectLoot_NodeTypeParams_OperationData>) CR2WTypeManager.Create("array:questInjectLoot_NodeTypeParams_OperationData", "operations", cr2w, this);
				}
				return _operations;
			}
			set
			{
				if (_operations == value)
				{
					return;
				}
				_operations = value;
				PropertySet(this);
			}
		}

		public questInjectLoot_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

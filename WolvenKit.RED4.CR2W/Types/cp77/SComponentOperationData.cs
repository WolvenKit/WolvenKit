using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SComponentOperationData : CVariable
	{
		private CName _componentName;
		private CEnum<EComponentOperation> _operationType;

		[Ordinal(0)] 
		[RED("componentName")] 
		public CName ComponentName
		{
			get
			{
				if (_componentName == null)
				{
					_componentName = (CName) CR2WTypeManager.Create("CName", "componentName", cr2w, this);
				}
				return _componentName;
			}
			set
			{
				if (_componentName == value)
				{
					return;
				}
				_componentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operationType")] 
		public CEnum<EComponentOperation> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EComponentOperation>) CR2WTypeManager.Create("EComponentOperation", "operationType", cr2w, this);
				}
				return _operationType;
			}
			set
			{
				if (_operationType == value)
				{
					return;
				}
				_operationType = value;
				PropertySet(this);
			}
		}

		public SComponentOperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

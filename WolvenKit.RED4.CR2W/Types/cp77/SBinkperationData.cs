using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SBinkperationData : CVariable
	{
		private CName _componentName;
		private redResourceReferenceScriptToken _binkPath;
		private CBool _loop;
		private CEnum<EBinkOperationType> _operationType;

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
		[RED("binkPath")] 
		public redResourceReferenceScriptToken BinkPath
		{
			get
			{
				if (_binkPath == null)
				{
					_binkPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "binkPath", cr2w, this);
				}
				return _binkPath;
			}
			set
			{
				if (_binkPath == value)
				{
					return;
				}
				_binkPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("loop")] 
		public CBool Loop
		{
			get
			{
				if (_loop == null)
				{
					_loop = (CBool) CR2WTypeManager.Create("Bool", "loop", cr2w, this);
				}
				return _loop;
			}
			set
			{
				if (_loop == value)
				{
					return;
				}
				_loop = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<EBinkOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EBinkOperationType>) CR2WTypeManager.Create("EBinkOperationType", "operationType", cr2w, this);
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

		public SBinkperationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

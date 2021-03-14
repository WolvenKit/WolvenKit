using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SWorkspotData : CVariable
	{
		private CName _componentName;
		private CBool _freeCamera;
		private CEnum<EWorkspotOperationType> _operationType;

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
		[RED("freeCamera")] 
		public CBool FreeCamera
		{
			get
			{
				if (_freeCamera == null)
				{
					_freeCamera = (CBool) CR2WTypeManager.Create("Bool", "freeCamera", cr2w, this);
				}
				return _freeCamera;
			}
			set
			{
				if (_freeCamera == value)
				{
					return;
				}
				_freeCamera = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("operationType")] 
		public CEnum<EWorkspotOperationType> OperationType
		{
			get
			{
				if (_operationType == null)
				{
					_operationType = (CEnum<EWorkspotOperationType>) CR2WTypeManager.Create("EWorkspotOperationType", "operationType", cr2w, this);
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

		public SWorkspotData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

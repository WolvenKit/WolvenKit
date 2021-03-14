using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GravityChangeTrigger : gameObject
	{
		private CEnum<EGravityType> _gravityType;
		private CName _regularStateMachineName;
		private CName _lowGravityStateMachineName;

		[Ordinal(40)] 
		[RED("gravityType")] 
		public CEnum<EGravityType> GravityType
		{
			get
			{
				if (_gravityType == null)
				{
					_gravityType = (CEnum<EGravityType>) CR2WTypeManager.Create("EGravityType", "gravityType", cr2w, this);
				}
				return _gravityType;
			}
			set
			{
				if (_gravityType == value)
				{
					return;
				}
				_gravityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("regularStateMachineName")] 
		public CName RegularStateMachineName
		{
			get
			{
				if (_regularStateMachineName == null)
				{
					_regularStateMachineName = (CName) CR2WTypeManager.Create("CName", "regularStateMachineName", cr2w, this);
				}
				return _regularStateMachineName;
			}
			set
			{
				if (_regularStateMachineName == value)
				{
					return;
				}
				_regularStateMachineName = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("lowGravityStateMachineName")] 
		public CName LowGravityStateMachineName
		{
			get
			{
				if (_lowGravityStateMachineName == null)
				{
					_lowGravityStateMachineName = (CName) CR2WTypeManager.Create("CName", "lowGravityStateMachineName", cr2w, this);
				}
				return _lowGravityStateMachineName;
			}
			set
			{
				if (_lowGravityStateMachineName == value)
				{
					return;
				}
				_lowGravityStateMachineName = value;
				PropertySet(this);
			}
		}

		public GravityChangeTrigger(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

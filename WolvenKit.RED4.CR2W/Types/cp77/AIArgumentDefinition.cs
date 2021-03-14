using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIArgumentDefinition : ISerializable
	{
		private CName _name;
		private CBool _isPersistent;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPersistent")] 
		public CBool IsPersistent
		{
			get
			{
				if (_isPersistent == null)
				{
					_isPersistent = (CBool) CR2WTypeManager.Create("Bool", "isPersistent", cr2w, this);
				}
				return _isPersistent;
			}
			set
			{
				if (_isPersistent == value)
				{
					return;
				}
				_isPersistent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get
			{
				if (_behaviorCallbackName == null)
				{
					_behaviorCallbackName = (CName) CR2WTypeManager.Create("CName", "behaviorCallbackName", cr2w, this);
				}
				return _behaviorCallbackName;
			}
			set
			{
				if (_behaviorCallbackName == value)
				{
					return;
				}
				_behaviorCallbackName = value;
				PropertySet(this);
			}
		}

		public AIArgumentDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

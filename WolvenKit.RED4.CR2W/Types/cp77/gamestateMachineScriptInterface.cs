using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineScriptInterface : IScriptable
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _executionOwner;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get
			{
				if (_executionOwner == null)
				{
					_executionOwner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "executionOwner", cr2w, this);
				}
				return _executionOwner;
			}
			set
			{
				if (_executionOwner == value)
				{
					return;
				}
				_executionOwner = value;
				PropertySet(this);
			}
		}

		public gamestateMachineScriptInterface(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

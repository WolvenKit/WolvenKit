using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SequenceCallback : redEvent
	{
		private gamePersistentID _persistentID;
		private CName _className;
		private CHandle<ScriptableDeviceAction> _actionToForward;

		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get
			{
				if (_persistentID == null)
				{
					_persistentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "persistentID", cr2w, this);
				}
				return _persistentID;
			}
			set
			{
				if (_persistentID == value)
				{
					return;
				}
				_persistentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("className")] 
		public CName ClassName
		{
			get
			{
				if (_className == null)
				{
					_className = (CName) CR2WTypeManager.Create("CName", "className", cr2w, this);
				}
				return _className;
			}
			set
			{
				if (_className == value)
				{
					return;
				}
				_className = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("actionToForward")] 
		public CHandle<ScriptableDeviceAction> ActionToForward
		{
			get
			{
				if (_actionToForward == null)
				{
					_actionToForward = (CHandle<ScriptableDeviceAction>) CR2WTypeManager.Create("handle:ScriptableDeviceAction", "actionToForward", cr2w, this);
				}
				return _actionToForward;
			}
			set
			{
				if (_actionToForward == value)
				{
					return;
				}
				_actionToForward = value;
				PropertySet(this);
			}
		}

		public SequenceCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

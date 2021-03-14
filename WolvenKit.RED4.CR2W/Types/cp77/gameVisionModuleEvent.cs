using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModuleEvent : redEvent
	{
		private CName _changedModule;
		private wCHandle<gameObject> _activator;
		private CBool _activated;

		[Ordinal(0)] 
		[RED("changedModule")] 
		public CName ChangedModule
		{
			get
			{
				if (_changedModule == null)
				{
					_changedModule = (CName) CR2WTypeManager.Create("CName", "changedModule", cr2w, this);
				}
				return _changedModule;
			}
			set
			{
				if (_changedModule == value)
				{
					return;
				}
				_changedModule = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activator")] 
		public wCHandle<gameObject> Activator
		{
			get
			{
				if (_activator == null)
				{
					_activator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "activator", cr2w, this);
				}
				return _activator;
			}
			set
			{
				if (_activator == value)
				{
					return;
				}
				_activator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("activated")] 
		public CBool Activated
		{
			get
			{
				if (_activated == null)
				{
					_activated = (CBool) CR2WTypeManager.Create("Bool", "activated", cr2w, this);
				}
				return _activated;
			}
			set
			{
				if (_activated == value)
				{
					return;
				}
				_activated = value;
				PropertySet(this);
			}
		}

		public gameVisionModuleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

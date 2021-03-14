using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionModeVisualEvent : redEvent
	{
		private TweakDBID _group;
		private CName _changedModule;
		private CBool _activated;
		private CName _meshComponentName;
		private CEnum<gameVisionModeType> _type;

		[Ordinal(0)] 
		[RED("group")] 
		public TweakDBID Group
		{
			get
			{
				if (_group == null)
				{
					_group = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "group", cr2w, this);
				}
				return _group;
			}
			set
			{
				if (_group == value)
				{
					return;
				}
				_group = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(3)] 
		[RED("meshComponentName")] 
		public CName MeshComponentName
		{
			get
			{
				if (_meshComponentName == null)
				{
					_meshComponentName = (CName) CR2WTypeManager.Create("CName", "meshComponentName", cr2w, this);
				}
				return _meshComponentName;
			}
			set
			{
				if (_meshComponentName == value)
				{
					return;
				}
				_meshComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameVisionModeType>) CR2WTypeManager.Create("gameVisionModeType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public gameVisionModeVisualEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

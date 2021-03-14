using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectDefinition : ISerializable
	{
		private rRef<gameSmartObjectResource> _resource;
		private CArray<CName> _actions;
		private rRef<animActionAnimDatabase> _motionActionDatabase;
		private CBool _enabled;
		private CBool _overrideGeneratedParameters;

		[Ordinal(0)] 
		[RED("resource")] 
		public rRef<gameSmartObjectResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (rRef<gameSmartObjectResource>) CR2WTypeManager.Create("rRef:gameSmartObjectResource", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CName> Actions
		{
			get
			{
				if (_actions == null)
				{
					_actions = (CArray<CName>) CR2WTypeManager.Create("array:CName", "actions", cr2w, this);
				}
				return _actions;
			}
			set
			{
				if (_actions == value)
				{
					return;
				}
				_actions = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("motionActionDatabase")] 
		public rRef<animActionAnimDatabase> MotionActionDatabase
		{
			get
			{
				if (_motionActionDatabase == null)
				{
					_motionActionDatabase = (rRef<animActionAnimDatabase>) CR2WTypeManager.Create("rRef:animActionAnimDatabase", "motionActionDatabase", cr2w, this);
				}
				return _motionActionDatabase;
			}
			set
			{
				if (_motionActionDatabase == value)
				{
					return;
				}
				_motionActionDatabase = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get
			{
				if (_enabled == null)
				{
					_enabled = (CBool) CR2WTypeManager.Create("Bool", "enabled", cr2w, this);
				}
				return _enabled;
			}
			set
			{
				if (_enabled == value)
				{
					return;
				}
				_enabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("overrideGeneratedParameters")] 
		public CBool OverrideGeneratedParameters
		{
			get
			{
				if (_overrideGeneratedParameters == null)
				{
					_overrideGeneratedParameters = (CBool) CR2WTypeManager.Create("Bool", "overrideGeneratedParameters", cr2w, this);
				}
				return _overrideGeneratedParameters;
			}
			set
			{
				if (_overrideGeneratedParameters == value)
				{
					return;
				}
				_overrideGeneratedParameters = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsCollisionFilterResource : ISerializable
	{
		private rRef<JsonResource> _presetJson;
		private rRef<JsonResource> _overridesJson;
		private CStatic<CName> _collisionGroups;
		private CStatic<CName> _queryGroups;

		[Ordinal(0)] 
		[RED("presetJson")] 
		public rRef<JsonResource> PresetJson
		{
			get
			{
				if (_presetJson == null)
				{
					_presetJson = (rRef<JsonResource>) CR2WTypeManager.Create("rRef:JsonResource", "presetJson", cr2w, this);
				}
				return _presetJson;
			}
			set
			{
				if (_presetJson == value)
				{
					return;
				}
				_presetJson = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("overridesJson")] 
		public rRef<JsonResource> OverridesJson
		{
			get
			{
				if (_overridesJson == null)
				{
					_overridesJson = (rRef<JsonResource>) CR2WTypeManager.Create("rRef:JsonResource", "overridesJson", cr2w, this);
				}
				return _overridesJson;
			}
			set
			{
				if (_overridesJson == value)
				{
					return;
				}
				_overridesJson = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("collisionGroups", 64)] 
		public CStatic<CName> CollisionGroups
		{
			get
			{
				if (_collisionGroups == null)
				{
					_collisionGroups = (CStatic<CName>) CR2WTypeManager.Create("static:64,CName", "collisionGroups", cr2w, this);
				}
				return _collisionGroups;
			}
			set
			{
				if (_collisionGroups == value)
				{
					return;
				}
				_collisionGroups = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("queryGroups", 64)] 
		public CStatic<CName> QueryGroups
		{
			get
			{
				if (_queryGroups == null)
				{
					_queryGroups = (CStatic<CName>) CR2WTypeManager.Create("static:64,CName", "queryGroups", cr2w, this);
				}
				return _queryGroups;
			}
			set
			{
				if (_queryGroups == value)
				{
					return;
				}
				_queryGroups = value;
				PropertySet(this);
			}
		}

		public physicsCollisionFilterResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

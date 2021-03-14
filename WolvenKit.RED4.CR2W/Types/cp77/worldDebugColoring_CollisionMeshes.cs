using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_CollisionMeshes : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _prefabColor;
		private CColor _collisionMeshColor;

		[Ordinal(0)] 
		[RED("defaultColor")] 
		public CColor DefaultColor
		{
			get
			{
				if (_defaultColor == null)
				{
					_defaultColor = (CColor) CR2WTypeManager.Create("Color", "defaultColor", cr2w, this);
				}
				return _defaultColor;
			}
			set
			{
				if (_defaultColor == value)
				{
					return;
				}
				_defaultColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("prefabColor")] 
		public CColor PrefabColor
		{
			get
			{
				if (_prefabColor == null)
				{
					_prefabColor = (CColor) CR2WTypeManager.Create("Color", "prefabColor", cr2w, this);
				}
				return _prefabColor;
			}
			set
			{
				if (_prefabColor == value)
				{
					return;
				}
				_prefabColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("collisionMeshColor")] 
		public CColor CollisionMeshColor
		{
			get
			{
				if (_collisionMeshColor == null)
				{
					_collisionMeshColor = (CColor) CR2WTypeManager.Create("Color", "collisionMeshColor", cr2w, this);
				}
				return _collisionMeshColor;
			}
			set
			{
				if (_collisionMeshColor == value)
				{
					return;
				}
				_collisionMeshColor = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_CollisionMeshes(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkMenuEntry : CVariable
	{
		private CName _name;
		private rRef<inkWidgetLibraryResource> _menuWidget;
		private CUInt32 _depth;
		private CEnum<inkSpawnMode> _spawnMode;
		private CBool _isAffectedByFadeout;

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
		[RED("menuWidget")] 
		public rRef<inkWidgetLibraryResource> MenuWidget
		{
			get
			{
				if (_menuWidget == null)
				{
					_menuWidget = (rRef<inkWidgetLibraryResource>) CR2WTypeManager.Create("rRef:inkWidgetLibraryResource", "menuWidget", cr2w, this);
				}
				return _menuWidget;
			}
			set
			{
				if (_menuWidget == value)
				{
					return;
				}
				_menuWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("depth")] 
		public CUInt32 Depth
		{
			get
			{
				if (_depth == null)
				{
					_depth = (CUInt32) CR2WTypeManager.Create("Uint32", "depth", cr2w, this);
				}
				return _depth;
			}
			set
			{
				if (_depth == value)
				{
					return;
				}
				_depth = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("spawnMode")] 
		public CEnum<inkSpawnMode> SpawnMode
		{
			get
			{
				if (_spawnMode == null)
				{
					_spawnMode = (CEnum<inkSpawnMode>) CR2WTypeManager.Create("inkSpawnMode", "spawnMode", cr2w, this);
				}
				return _spawnMode;
			}
			set
			{
				if (_spawnMode == value)
				{
					return;
				}
				_spawnMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isAffectedByFadeout")] 
		public CBool IsAffectedByFadeout
		{
			get
			{
				if (_isAffectedByFadeout == null)
				{
					_isAffectedByFadeout = (CBool) CR2WTypeManager.Create("Bool", "isAffectedByFadeout", cr2w, this);
				}
				return _isAffectedByFadeout;
			}
			set
			{
				if (_isAffectedByFadeout == value)
				{
					return;
				}
				_isAffectedByFadeout = value;
				PropertySet(this);
			}
		}

		public inkMenuEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDebugColoring_Duplicates : worldEditorDebugColoringSettings
	{
		private CColor _defaultColor;
		private CColor _duplicateColor;
		private rRef<worldPrefab> _refreshPrefab;
		private CBool _refresh;

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
		[RED("duplicateColor")] 
		public CColor DuplicateColor
		{
			get
			{
				if (_duplicateColor == null)
				{
					_duplicateColor = (CColor) CR2WTypeManager.Create("Color", "duplicateColor", cr2w, this);
				}
				return _duplicateColor;
			}
			set
			{
				if (_duplicateColor == value)
				{
					return;
				}
				_duplicateColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("refreshPrefab")] 
		public rRef<worldPrefab> RefreshPrefab
		{
			get
			{
				if (_refreshPrefab == null)
				{
					_refreshPrefab = (rRef<worldPrefab>) CR2WTypeManager.Create("rRef:worldPrefab", "refreshPrefab", cr2w, this);
				}
				return _refreshPrefab;
			}
			set
			{
				if (_refreshPrefab == value)
				{
					return;
				}
				_refreshPrefab = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("refresh")] 
		public CBool Refresh
		{
			get
			{
				if (_refresh == null)
				{
					_refresh = (CBool) CR2WTypeManager.Create("Bool", "refresh", cr2w, this);
				}
				return _refresh;
			}
			set
			{
				if (_refresh == value)
				{
					return;
				}
				_refresh = value;
				PropertySet(this);
			}
		}

		public worldDebugColoring_Duplicates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

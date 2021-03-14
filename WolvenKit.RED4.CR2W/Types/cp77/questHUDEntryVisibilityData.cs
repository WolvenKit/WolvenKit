using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questHUDEntryVisibilityData : CVariable
	{
		private CName _hudEntryName;
		private CEnum<worlduiEntryVisibility> _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CName HudEntryName
		{
			get
			{
				if (_hudEntryName == null)
				{
					_hudEntryName = (CName) CR2WTypeManager.Create("CName", "hudEntryName", cr2w, this);
				}
				return _hudEntryName;
			}
			set
			{
				if (_hudEntryName == value)
				{
					return;
				}
				_hudEntryName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("visibility")] 
		public CEnum<worlduiEntryVisibility> Visibility
		{
			get
			{
				if (_visibility == null)
				{
					_visibility = (CEnum<worlduiEntryVisibility>) CR2WTypeManager.Create("worlduiEntryVisibility", "visibility", cr2w, this);
				}
				return _visibility;
			}
			set
			{
				if (_visibility == value)
				{
					return;
				}
				_visibility = value;
				PropertySet(this);
			}
		}

		public questHUDEntryVisibilityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

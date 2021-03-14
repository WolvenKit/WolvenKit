using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetHUDEntryForcedVisibility_NodeType : questIUIManagerNodeType
	{
		private CArray<CName> _hudEntryName;
		private CBool _usePreset;
		private TweakDBID _hudVisibilityPreset;
		private CEnum<worlduiEntryVisibility> _visibility;

		[Ordinal(0)] 
		[RED("hudEntryName")] 
		public CArray<CName> HudEntryName
		{
			get
			{
				if (_hudEntryName == null)
				{
					_hudEntryName = (CArray<CName>) CR2WTypeManager.Create("array:CName", "hudEntryName", cr2w, this);
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
		[RED("usePreset")] 
		public CBool UsePreset
		{
			get
			{
				if (_usePreset == null)
				{
					_usePreset = (CBool) CR2WTypeManager.Create("Bool", "usePreset", cr2w, this);
				}
				return _usePreset;
			}
			set
			{
				if (_usePreset == value)
				{
					return;
				}
				_usePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hudVisibilityPreset")] 
		public TweakDBID HudVisibilityPreset
		{
			get
			{
				if (_hudVisibilityPreset == null)
				{
					_hudVisibilityPreset = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "hudVisibilityPreset", cr2w, this);
				}
				return _hudVisibilityPreset;
			}
			set
			{
				if (_hudVisibilityPreset == value)
				{
					return;
				}
				_hudVisibilityPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		public questSetHUDEntryForcedVisibility_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

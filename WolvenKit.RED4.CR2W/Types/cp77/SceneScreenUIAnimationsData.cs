using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneScreenUIAnimationsData : IScriptable
	{
		private CHandle<WidgetAnimationManager> _customAnimations;
		private CArray<CName> _onSpawnAnimations;
		private CName _defaultLibraryItemName;
		private CEnum<inkEAnchor> _defaultLibraryItemAnchor;

		[Ordinal(0)] 
		[RED("customAnimations")] 
		public CHandle<WidgetAnimationManager> CustomAnimations
		{
			get
			{
				if (_customAnimations == null)
				{
					_customAnimations = (CHandle<WidgetAnimationManager>) CR2WTypeManager.Create("handle:WidgetAnimationManager", "customAnimations", cr2w, this);
				}
				return _customAnimations;
			}
			set
			{
				if (_customAnimations == value)
				{
					return;
				}
				_customAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("onSpawnAnimations")] 
		public CArray<CName> OnSpawnAnimations
		{
			get
			{
				if (_onSpawnAnimations == null)
				{
					_onSpawnAnimations = (CArray<CName>) CR2WTypeManager.Create("array:CName", "onSpawnAnimations", cr2w, this);
				}
				return _onSpawnAnimations;
			}
			set
			{
				if (_onSpawnAnimations == value)
				{
					return;
				}
				_onSpawnAnimations = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("defaultLibraryItemName")] 
		public CName DefaultLibraryItemName
		{
			get
			{
				if (_defaultLibraryItemName == null)
				{
					_defaultLibraryItemName = (CName) CR2WTypeManager.Create("CName", "defaultLibraryItemName", cr2w, this);
				}
				return _defaultLibraryItemName;
			}
			set
			{
				if (_defaultLibraryItemName == value)
				{
					return;
				}
				_defaultLibraryItemName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("defaultLibraryItemAnchor")] 
		public CEnum<inkEAnchor> DefaultLibraryItemAnchor
		{
			get
			{
				if (_defaultLibraryItemAnchor == null)
				{
					_defaultLibraryItemAnchor = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "defaultLibraryItemAnchor", cr2w, this);
				}
				return _defaultLibraryItemAnchor;
			}
			set
			{
				if (_defaultLibraryItemAnchor == value)
				{
					return;
				}
				_defaultLibraryItemAnchor = value;
				PropertySet(this);
			}
		}

		public SceneScreenUIAnimationsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

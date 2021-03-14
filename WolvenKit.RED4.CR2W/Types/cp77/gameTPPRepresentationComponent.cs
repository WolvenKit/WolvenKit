using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTPPRepresentationComponent : entIComponent
	{
		private CArray<gameFppRepDetachedObjectInfo> _detachedObjectInfo;
		private CArray<gameTppRepAttachedObjectInfo> _attachedObjectInfo;
		private CArray<TweakDBID> _affectedAppearanceSlots;

		[Ordinal(3)] 
		[RED("detachedObjectInfo")] 
		public CArray<gameFppRepDetachedObjectInfo> DetachedObjectInfo
		{
			get
			{
				if (_detachedObjectInfo == null)
				{
					_detachedObjectInfo = (CArray<gameFppRepDetachedObjectInfo>) CR2WTypeManager.Create("array:gameFppRepDetachedObjectInfo", "detachedObjectInfo", cr2w, this);
				}
				return _detachedObjectInfo;
			}
			set
			{
				if (_detachedObjectInfo == value)
				{
					return;
				}
				_detachedObjectInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("attachedObjectInfo")] 
		public CArray<gameTppRepAttachedObjectInfo> AttachedObjectInfo
		{
			get
			{
				if (_attachedObjectInfo == null)
				{
					_attachedObjectInfo = (CArray<gameTppRepAttachedObjectInfo>) CR2WTypeManager.Create("array:gameTppRepAttachedObjectInfo", "attachedObjectInfo", cr2w, this);
				}
				return _attachedObjectInfo;
			}
			set
			{
				if (_attachedObjectInfo == value)
				{
					return;
				}
				_attachedObjectInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("affectedAppearanceSlots")] 
		public CArray<TweakDBID> AffectedAppearanceSlots
		{
			get
			{
				if (_affectedAppearanceSlots == null)
				{
					_affectedAppearanceSlots = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "affectedAppearanceSlots", cr2w, this);
				}
				return _affectedAppearanceSlots;
			}
			set
			{
				if (_affectedAppearanceSlots == value)
				{
					return;
				}
				_affectedAppearanceSlots = value;
				PropertySet(this);
			}
		}

		public gameTPPRepresentationComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

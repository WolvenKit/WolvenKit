using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NameplateVisibleEvent : redEvent
	{
		private CBool _isNameplateVisible;
		private entEntityID _entityID;

		[Ordinal(0)] 
		[RED("isNameplateVisible")] 
		public CBool IsNameplateVisible
		{
			get
			{
				if (_isNameplateVisible == null)
				{
					_isNameplateVisible = (CBool) CR2WTypeManager.Create("Bool", "isNameplateVisible", cr2w, this);
				}
				return _isNameplateVisible;
			}
			set
			{
				if (_isNameplateVisible == value)
				{
					return;
				}
				_isNameplateVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		public NameplateVisibleEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

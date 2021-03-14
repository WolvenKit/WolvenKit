using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstallItemPart : gameScriptableSystemRequest
	{
		private wCHandle<gameObject> _obj;
		private gameItemID _baseItem;
		private gameItemID _partToInstall;
		private TweakDBID _slotID;

		[Ordinal(0)] 
		[RED("obj")] 
		public wCHandle<gameObject> Obj
		{
			get
			{
				if (_obj == null)
				{
					_obj = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "obj", cr2w, this);
				}
				return _obj;
			}
			set
			{
				if (_obj == value)
				{
					return;
				}
				_obj = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("baseItem")] 
		public gameItemID BaseItem
		{
			get
			{
				if (_baseItem == null)
				{
					_baseItem = (gameItemID) CR2WTypeManager.Create("gameItemID", "baseItem", cr2w, this);
				}
				return _baseItem;
			}
			set
			{
				if (_baseItem == value)
				{
					return;
				}
				_baseItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("partToInstall")] 
		public gameItemID PartToInstall
		{
			get
			{
				if (_partToInstall == null)
				{
					_partToInstall = (gameItemID) CR2WTypeManager.Create("gameItemID", "partToInstall", cr2w, this);
				}
				return _partToInstall;
			}
			set
			{
				if (_partToInstall == value)
				{
					return;
				}
				_partToInstall = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get
			{
				if (_slotID == null)
				{
					_slotID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotID", cr2w, this);
				}
				return _slotID;
			}
			set
			{
				if (_slotID == value)
				{
					return;
				}
				_slotID = value;
				PropertySet(this);
			}
		}

		public InstallItemPart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

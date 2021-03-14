using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineparameterTypeItemEquipRequest : IScriptable
	{
		private TweakDBID _slotId;
		private gameItemID _itemId;
		private CEnum<ERenderingPlane> _startingRenderingPlane;

		[Ordinal(0)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("itemId")] 
		public gameItemID ItemId
		{
			get
			{
				if (_itemId == null)
				{
					_itemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemId", cr2w, this);
				}
				return _itemId;
			}
			set
			{
				if (_itemId == value)
				{
					return;
				}
				_itemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("startingRenderingPlane")] 
		public CEnum<ERenderingPlane> StartingRenderingPlane
		{
			get
			{
				if (_startingRenderingPlane == null)
				{
					_startingRenderingPlane = (CEnum<ERenderingPlane>) CR2WTypeManager.Create("ERenderingPlane", "startingRenderingPlane", cr2w, this);
				}
				return _startingRenderingPlane;
			}
			set
			{
				if (_startingRenderingPlane == value)
				{
					return;
				}
				_startingRenderingPlane = value;
				PropertySet(this);
			}
		}

		public gamestateMachineparameterTypeItemEquipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

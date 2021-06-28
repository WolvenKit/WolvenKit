using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDrawItemRequest : gamePlayerScriptableSystemRequest
	{
		private gameItemID _itemID;
		private CEnum<gameEquipAnimationType> _equipAnimationType;
		private CBool _assignOnly;

		[Ordinal(1)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(2)] 
		[RED("equipAnimationType")] 
		public CEnum<gameEquipAnimationType> EquipAnimationType
		{
			get => GetProperty(ref _equipAnimationType);
			set => SetProperty(ref _equipAnimationType, value);
		}

		[Ordinal(3)] 
		[RED("assignOnly")] 
		public CBool AssignOnly
		{
			get => GetProperty(ref _assignOnly);
			set => SetProperty(ref _assignOnly, value);
		}

		public gameDrawItemRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

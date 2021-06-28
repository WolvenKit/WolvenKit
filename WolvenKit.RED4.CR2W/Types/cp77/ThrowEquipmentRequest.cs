using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowEquipmentRequest : gamePlayerScriptableSystemRequest
	{
		private wCHandle<gameItemObject> _itemObject;

		[Ordinal(1)] 
		[RED("itemObject")] 
		public wCHandle<gameItemObject> ItemObject
		{
			get => GetProperty(ref _itemObject);
			set => SetProperty(ref _itemObject, value);
		}

		public ThrowEquipmentRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPropOwnershipTransferOptions : CVariable
	{
		private CEnum<scnPropOwnershipTransferOptionsType> _type;
		private CBool _dettachFromSlot;
		private CBool _removeFromInventory;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnPropOwnershipTransferOptionsType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(1)] 
		[RED("dettachFromSlot")] 
		public CBool DettachFromSlot
		{
			get => GetProperty(ref _dettachFromSlot);
			set => SetProperty(ref _dettachFromSlot, value);
		}

		[Ordinal(2)] 
		[RED("removeFromInventory")] 
		public CBool RemoveFromInventory
		{
			get => GetProperty(ref _removeFromInventory);
			set => SetProperty(ref _removeFromInventory, value);
		}

		public scnPropOwnershipTransferOptions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

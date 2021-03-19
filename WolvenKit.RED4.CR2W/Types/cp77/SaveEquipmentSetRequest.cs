using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;
		private CEnum<gameEquipmentSetType> _setType;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		[Ordinal(2)] 
		[RED("setType")] 
		public CEnum<gameEquipmentSetType> SetType
		{
			get => GetProperty(ref _setType);
			set => SetProperty(ref _setType, value);
		}

		public SaveEquipmentSetRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

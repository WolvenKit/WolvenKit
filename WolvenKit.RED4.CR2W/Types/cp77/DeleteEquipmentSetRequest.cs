using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeleteEquipmentSetRequest : gamePlayerScriptableSystemRequest
	{
		private CString _setName;

		[Ordinal(1)] 
		[RED("setName")] 
		public CString SetName
		{
			get => GetProperty(ref _setName);
			set => SetProperty(ref _setName, value);
		}

		public DeleteEquipmentSetRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

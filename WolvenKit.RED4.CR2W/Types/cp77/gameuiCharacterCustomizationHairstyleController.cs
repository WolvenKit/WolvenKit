using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _headGroupName;

		[Ordinal(3)] 
		[RED("headGroupName")] 
		public CName HeadGroupName
		{
			get => GetProperty(ref _headGroupName);
			set => SetProperty(ref _headGroupName, value);
		}

		public gameuiCharacterCustomizationHairstyleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

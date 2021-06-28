using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationFeetController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _liftedFeetGroupName;
		private CName _flatFeetGroupName;

		[Ordinal(3)] 
		[RED("liftedFeetGroupName")] 
		public CName LiftedFeetGroupName
		{
			get => GetProperty(ref _liftedFeetGroupName);
			set => SetProperty(ref _liftedFeetGroupName, value);
		}

		[Ordinal(4)] 
		[RED("flatFeetGroupName")] 
		public CName FlatFeetGroupName
		{
			get => GetProperty(ref _flatFeetGroupName);
			set => SetProperty(ref _flatFeetGroupName, value);
		}

		public gameuiCharacterCustomizationFeetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

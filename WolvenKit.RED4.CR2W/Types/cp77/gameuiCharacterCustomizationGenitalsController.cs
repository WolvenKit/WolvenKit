using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationGenitalsController : gameuiCharacterCustomizationBodyPartsController
	{
		private CName _upperBodyGroupName;
		private CName _bottomBodyGroupName;
		private CBool _forceHideGenitals;

		[Ordinal(3)] 
		[RED("upperBodyGroupName")] 
		public CName UpperBodyGroupName
		{
			get => GetProperty(ref _upperBodyGroupName);
			set => SetProperty(ref _upperBodyGroupName, value);
		}

		[Ordinal(4)] 
		[RED("bottomBodyGroupName")] 
		public CName BottomBodyGroupName
		{
			get => GetProperty(ref _bottomBodyGroupName);
			set => SetProperty(ref _bottomBodyGroupName, value);
		}

		[Ordinal(5)] 
		[RED("forceHideGenitals")] 
		public CBool ForceHideGenitals
		{
			get => GetProperty(ref _forceHideGenitals);
			set => SetProperty(ref _forceHideGenitals, value);
		}

		public gameuiCharacterCustomizationGenitalsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

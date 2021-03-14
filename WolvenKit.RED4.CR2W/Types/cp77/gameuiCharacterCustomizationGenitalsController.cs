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
			get
			{
				if (_upperBodyGroupName == null)
				{
					_upperBodyGroupName = (CName) CR2WTypeManager.Create("CName", "upperBodyGroupName", cr2w, this);
				}
				return _upperBodyGroupName;
			}
			set
			{
				if (_upperBodyGroupName == value)
				{
					return;
				}
				_upperBodyGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bottomBodyGroupName")] 
		public CName BottomBodyGroupName
		{
			get
			{
				if (_bottomBodyGroupName == null)
				{
					_bottomBodyGroupName = (CName) CR2WTypeManager.Create("CName", "bottomBodyGroupName", cr2w, this);
				}
				return _bottomBodyGroupName;
			}
			set
			{
				if (_bottomBodyGroupName == value)
				{
					return;
				}
				_bottomBodyGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("forceHideGenitals")] 
		public CBool ForceHideGenitals
		{
			get
			{
				if (_forceHideGenitals == null)
				{
					_forceHideGenitals = (CBool) CR2WTypeManager.Create("Bool", "forceHideGenitals", cr2w, this);
				}
				return _forceHideGenitals;
			}
			set
			{
				if (_forceHideGenitals == value)
				{
					return;
				}
				_forceHideGenitals = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationGenitalsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

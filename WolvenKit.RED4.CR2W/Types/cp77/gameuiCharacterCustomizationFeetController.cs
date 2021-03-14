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
			get
			{
				if (_liftedFeetGroupName == null)
				{
					_liftedFeetGroupName = (CName) CR2WTypeManager.Create("CName", "liftedFeetGroupName", cr2w, this);
				}
				return _liftedFeetGroupName;
			}
			set
			{
				if (_liftedFeetGroupName == value)
				{
					return;
				}
				_liftedFeetGroupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("flatFeetGroupName")] 
		public CName FlatFeetGroupName
		{
			get
			{
				if (_flatFeetGroupName == null)
				{
					_flatFeetGroupName = (CName) CR2WTypeManager.Create("CName", "flatFeetGroupName", cr2w, this);
				}
				return _flatFeetGroupName;
			}
			set
			{
				if (_flatFeetGroupName == value)
				{
					return;
				}
				_flatFeetGroupName = value;
				PropertySet(this);
			}
		}

		public gameuiCharacterCustomizationFeetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

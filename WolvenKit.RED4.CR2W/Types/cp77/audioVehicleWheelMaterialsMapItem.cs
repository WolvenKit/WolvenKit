using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleWheelMaterialsMapItem : CVariable
	{
		private CName _name;
		private CFloat _audioMaterialCoeff;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("audioMaterialCoeff")] 
		public CFloat AudioMaterialCoeff
		{
			get
			{
				if (_audioMaterialCoeff == null)
				{
					_audioMaterialCoeff = (CFloat) CR2WTypeManager.Create("Float", "audioMaterialCoeff", cr2w, this);
				}
				return _audioMaterialCoeff;
			}
			set
			{
				if (_audioMaterialCoeff == value)
				{
					return;
				}
				_audioMaterialCoeff = value;
				PropertySet(this);
			}
		}

		public audioVehicleWheelMaterialsMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAuxiliaryMetadata : CVariable
	{
		private CName _physicalPropSettings;

		[Ordinal(0)] 
		[RED("physicalPropSettings")] 
		public CName PhysicalPropSettings
		{
			get
			{
				if (_physicalPropSettings == null)
				{
					_physicalPropSettings = (CName) CR2WTypeManager.Create("CName", "physicalPropSettings", cr2w, this);
				}
				return _physicalPropSettings;
			}
			set
			{
				if (_physicalPropSettings == value)
				{
					return;
				}
				_physicalPropSettings = value;
				PropertySet(this);
			}
		}

		public audioAuxiliaryMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

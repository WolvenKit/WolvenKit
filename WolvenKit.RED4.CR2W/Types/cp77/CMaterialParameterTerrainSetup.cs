using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		private rRef<CTerrainSetup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public rRef<CTerrainSetup> Setup
		{
			get
			{
				if (_setup == null)
				{
					_setup = (rRef<CTerrainSetup>) CR2WTypeManager.Create("rRef:CTerrainSetup", "setup", cr2w, this);
				}
				return _setup;
			}
			set
			{
				if (_setup == value)
				{
					return;
				}
				_setup = value;
				PropertySet(this);
			}
		}

		public CMaterialParameterTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		private rRef<Multilayer_Setup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public rRef<Multilayer_Setup> Setup
		{
			get
			{
				if (_setup == null)
				{
					_setup = (rRef<Multilayer_Setup>) CR2WTypeManager.Create("rRef:Multilayer_Setup", "setup", cr2w, this);
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

		public CMaterialParameterMultilayerSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

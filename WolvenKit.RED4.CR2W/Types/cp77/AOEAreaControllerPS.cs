using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AOEAreaControllerPS : MasterControllerPS
	{
		private AOEAreaSetup _aOEAreaSetup;

		[Ordinal(104)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get
			{
				if (_aOEAreaSetup == null)
				{
					_aOEAreaSetup = (AOEAreaSetup) CR2WTypeManager.Create("AOEAreaSetup", "AOEAreaSetup", cr2w, this);
				}
				return _aOEAreaSetup;
			}
			set
			{
				if (_aOEAreaSetup == value)
				{
					return;
				}
				_aOEAreaSetup = value;
				PropertySet(this);
			}
		}

		public AOEAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

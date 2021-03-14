using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeviceSystemBaseControllerPS : MasterControllerPS
	{
		private CBool _quickHacksEnabled;

		[Ordinal(104)] 
		[RED("quickHacksEnabled")] 
		public CBool QuickHacksEnabled
		{
			get
			{
				if (_quickHacksEnabled == null)
				{
					_quickHacksEnabled = (CBool) CR2WTypeManager.Create("Bool", "quickHacksEnabled", cr2w, this);
				}
				return _quickHacksEnabled;
			}
			set
			{
				if (_quickHacksEnabled == value)
				{
					return;
				}
				_quickHacksEnabled = value;
				PropertySet(this);
			}
		}

		public DeviceSystemBaseControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

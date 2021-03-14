using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScanInstance : ModuleInstance
	{
		private CBool _isScanningCluesBlocked;

		[Ordinal(6)] 
		[RED("isScanningCluesBlocked")] 
		public CBool IsScanningCluesBlocked
		{
			get
			{
				if (_isScanningCluesBlocked == null)
				{
					_isScanningCluesBlocked = (CBool) CR2WTypeManager.Create("Bool", "isScanningCluesBlocked", cr2w, this);
				}
				return _isScanningCluesBlocked;
			}
			set
			{
				if (_isScanningCluesBlocked == value)
				{
					return;
				}
				_isScanningCluesBlocked = value;
				PropertySet(this);
			}
		}

		public ScanInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

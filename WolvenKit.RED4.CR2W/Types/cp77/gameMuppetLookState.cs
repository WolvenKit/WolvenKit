using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetLookState : CVariable
	{
		private EulerAngles _lookDir;

		[Ordinal(0)] 
		[RED("lookDir")] 
		public EulerAngles LookDir
		{
			get
			{
				if (_lookDir == null)
				{
					_lookDir = (EulerAngles) CR2WTypeManager.Create("EulerAngles", "lookDir", cr2w, this);
				}
				return _lookDir;
			}
			set
			{
				if (_lookDir == value)
				{
					return;
				}
				_lookDir = value;
				PropertySet(this);
			}
		}

		public gameMuppetLookState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

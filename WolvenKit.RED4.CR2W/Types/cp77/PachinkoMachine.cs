using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PachinkoMachine : ArcadeMachine
	{
		private CName _distractionFXName;

		[Ordinal(98)] 
		[RED("distractionFXName")] 
		public CName DistractionFXName
		{
			get
			{
				if (_distractionFXName == null)
				{
					_distractionFXName = (CName) CR2WTypeManager.Create("CName", "distractionFXName", cr2w, this);
				}
				return _distractionFXName;
			}
			set
			{
				if (_distractionFXName == value)
				{
					return;
				}
				_distractionFXName = value;
				PropertySet(this);
			}
		}

		public PachinkoMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

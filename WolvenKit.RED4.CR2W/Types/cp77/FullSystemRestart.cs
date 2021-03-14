using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FullSystemRestart : ActionBool
	{
		private CInt32 _restartDuration;

		[Ordinal(25)] 
		[RED("restartDuration")] 
		public CInt32 RestartDuration
		{
			get
			{
				if (_restartDuration == null)
				{
					_restartDuration = (CInt32) CR2WTypeManager.Create("Int32", "restartDuration", cr2w, this);
				}
				return _restartDuration;
			}
			set
			{
				if (_restartDuration == value)
				{
					return;
				}
				_restartDuration = value;
				PropertySet(this);
			}
		}

		public FullSystemRestart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

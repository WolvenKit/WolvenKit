using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseAnim : animAnimNode_SkAnim
	{
		private CName _phase;

		[Ordinal(30)] 
		[RED("phase")] 
		public CName Phase
		{
			get
			{
				if (_phase == null)
				{
					_phase = (CName) CR2WTypeManager.Create("CName", "phase", cr2w, this);
				}
				return _phase;
			}
			set
			{
				if (_phase == value)
				{
					return;
				}
				_phase = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkPhaseAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

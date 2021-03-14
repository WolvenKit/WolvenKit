using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreviousFearPhaseCheck : AIbehaviorconditionScript
	{
		private CInt32 _fearPhase;

		[Ordinal(0)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get
			{
				if (_fearPhase == null)
				{
					_fearPhase = (CInt32) CR2WTypeManager.Create("Int32", "fearPhase", cr2w, this);
				}
				return _fearPhase;
			}
			set
			{
				if (_fearPhase == value)
				{
					return;
				}
				_fearPhase = value;
				PropertySet(this);
			}
		}

		public PreviousFearPhaseCheck(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

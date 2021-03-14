using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entKillEffectEvent : redEvent
	{
		private CName _effectName;
		private CBool _breakAllLoops;

		[Ordinal(0)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get
			{
				if (_effectName == null)
				{
					_effectName = (CName) CR2WTypeManager.Create("CName", "effectName", cr2w, this);
				}
				return _effectName;
			}
			set
			{
				if (_effectName == value)
				{
					return;
				}
				_effectName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("breakAllLoops")] 
		public CBool BreakAllLoops
		{
			get
			{
				if (_breakAllLoops == null)
				{
					_breakAllLoops = (CBool) CR2WTypeManager.Create("Bool", "breakAllLoops", cr2w, this);
				}
				return _breakAllLoops;
			}
			set
			{
				if (_breakAllLoops == value)
				{
					return;
				}
				_breakAllLoops = value;
				PropertySet(this);
			}
		}

		public entKillEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_BeamVFX_Custom : gameEffectPostAction_BeamVFX
	{
		private raRef<worldEffect> _effect;
		private CBool _attached;
		private CBool _breakLoopOnDetach;
		private CBool _invert;
		private CName _effectTag;

		[Ordinal(0)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("attached")] 
		public CBool Attached
		{
			get
			{
				if (_attached == null)
				{
					_attached = (CBool) CR2WTypeManager.Create("Bool", "attached", cr2w, this);
				}
				return _attached;
			}
			set
			{
				if (_attached == value)
				{
					return;
				}
				_attached = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("breakLoopOnDetach")] 
		public CBool BreakLoopOnDetach
		{
			get
			{
				if (_breakLoopOnDetach == null)
				{
					_breakLoopOnDetach = (CBool) CR2WTypeManager.Create("Bool", "breakLoopOnDetach", cr2w, this);
				}
				return _breakLoopOnDetach;
			}
			set
			{
				if (_breakLoopOnDetach == value)
				{
					return;
				}
				_breakLoopOnDetach = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get
			{
				if (_effectTag == null)
				{
					_effectTag = (CName) CR2WTypeManager.Create("CName", "effectTag", cr2w, this);
				}
				return _effectTag;
			}
			set
			{
				if (_effectTag == value)
				{
					return;
				}
				_effectTag = value;
				PropertySet(this);
			}
		}

		public gameEffectPostAction_BeamVFX_Custom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

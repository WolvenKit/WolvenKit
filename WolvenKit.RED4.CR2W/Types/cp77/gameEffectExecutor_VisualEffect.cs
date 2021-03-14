using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_VisualEffect : gameEffectExecutor
	{
		private raRef<worldEffect> _effect;
		private CBool _attached;
		private CBool _breakLoopOnDetach;
		private CName _effectTag;
		private CHandle<gameEffectVectorEvaluator> _vectorEvaluator;

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(5)] 
		[RED("vectorEvaluator")] 
		public CHandle<gameEffectVectorEvaluator> VectorEvaluator
		{
			get
			{
				if (_vectorEvaluator == null)
				{
					_vectorEvaluator = (CHandle<gameEffectVectorEvaluator>) CR2WTypeManager.Create("handle:gameEffectVectorEvaluator", "vectorEvaluator", cr2w, this);
				}
				return _vectorEvaluator;
			}
			set
			{
				if (_vectorEvaluator == value)
				{
					return;
				}
				_vectorEvaluator = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_VisualEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreviewPreviewEffect : CVariable
	{
		private raRef<worldEffect> _effect;
		private CName _effectTag;
		private raRef<worldEffect> _effectSnap;
		private CName _effectSnapTag;
		private CFloat _forwardOffset;

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

		[Ordinal(2)] 
		[RED("effectSnap")] 
		public raRef<worldEffect> EffectSnap
		{
			get
			{
				if (_effectSnap == null)
				{
					_effectSnap = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "effectSnap", cr2w, this);
				}
				return _effectSnap;
			}
			set
			{
				if (_effectSnap == value)
				{
					return;
				}
				_effectSnap = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("effectSnapTag")] 
		public CName EffectSnapTag
		{
			get
			{
				if (_effectSnapTag == null)
				{
					_effectSnapTag = (CName) CR2WTypeManager.Create("CName", "effectSnapTag", cr2w, this);
				}
				return _effectSnapTag;
			}
			set
			{
				if (_effectSnapTag == value)
				{
					return;
				}
				_effectSnapTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get
			{
				if (_forwardOffset == null)
				{
					_forwardOffset = (CFloat) CR2WTypeManager.Create("Float", "forwardOffset", cr2w, this);
				}
				return _forwardOffset;
			}
			set
			{
				if (_forwardOffset == value)
				{
					return;
				}
				_forwardOffset = value;
				PropertySet(this);
			}
		}

		public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_KatanaBulletBendingEffectEntry : CVariable
	{
		private CName _tag;
		private raRef<worldEffect> _effect;
		private CBool _attach;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get
			{
				if (_tag == null)
				{
					_tag = (CName) CR2WTypeManager.Create("CName", "tag", cr2w, this);
				}
				return _tag;
			}
			set
			{
				if (_tag == value)
				{
					return;
				}
				_tag = value;
				PropertySet(this);
			}
		}

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
		[RED("attach")] 
		public CBool Attach
		{
			get
			{
				if (_attach == null)
				{
					_attach = (CBool) CR2WTypeManager.Create("Bool", "attach", cr2w, this);
				}
				return _attach;
			}
			set
			{
				if (_attach == value)
				{
					return;
				}
				_attach = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_KatanaBulletBendingEffectEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}

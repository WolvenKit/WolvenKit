using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnEffectDef : CVariable
	{
		private scnEffectId _id;
		private raRef<worldEffect> _effect;

		[Ordinal(0)] 
		[RED("id")] 
		public scnEffectId Id
		{
			get
			{
				if (_id == null)
				{
					_id = (scnEffectId) CR2WTypeManager.Create("scnEffectId", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
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

		public scnEffectDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
